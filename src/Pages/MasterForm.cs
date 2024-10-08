﻿using System.Collections.Generic;
using System.Drawing.Imaging;

namespace MDBEditor;

public partial class MasterForm : Form
{
    private readonly PictureBoxWithGrid BoxWithGrid;
    //private UndoRedoManager _undoRedoManager;
    private Graphics BoardGraphics;

    //Mouse event properties
    bool IsMouseDown = false;
    bool IsRulerOpen = false;
    private Point lastPoint;
    private Point StartPoint;

    //Colors
    public static Color primaryColor = Color.Black;
    public static Color secondaryColor = Color.White;

    //Tools
    private GeometricalShape? currentShape;
    private DrawingTool currentTool;
    private PenTool penTool;
    private EraserTool eraserTool;
    private ColorPickerTool colorPickerTool;
    private FillerTool fillerTool;
    private TextTool textTool;
    private ZoomTool zoomTool;
    private SelectAreaTool selectAreaTool;

    public MasterForm()
    {
        InitializeComponent();
        PB_Drawing_Board.Image = new Bitmap(PB_Drawing_Board.Width, PB_Drawing_Board.Height);
        BoardGraphics = Graphics.FromImage(PB_Drawing_Board.Image);
        //_undoRedoManager = new UndoRedoManager(PB_Drawing_Board);
        FLP_Colors.GetColors();
        FLP_Text_Colors.GetColors();
        Lbl_Page_Size.Text = string.Format(format: "{0} {1}", PB_Drawing_Board.Width, PB_Drawing_Board.Height);
        TC_Menu.TabPages.Remove(TP_Text);

        //Add grid control to drawing board
        BoxWithGrid = new PictureBoxWithGrid(PB_Drawing_Board.Size);
        PB_Drawing_Board.Controls.Add(BoxWithGrid);

        //Set location of drawing board before checked ruler checkbox
        PB_Drawing_Board.Location = BuiltInCoordinates.OldDrawingBoardCoordinate;

        //Add rulers to pictureboxes
        PB_Ruler_Left.Controls.Add(new RulerPictureBox(BoxAlignment.Vertical));
        PB_Ruler_Top.Controls.Add(new RulerPictureBox());
        this.Size = BuiltInCoordinates.RulerClosedCoordinate;

        //Tools
        penTool = new PenTool(BoardGraphics);
        eraserTool = new EraserTool(BoardGraphics);
        fillerTool = new FillerTool(PB_Drawing_Board);
        colorPickerTool = new ColorPickerTool(PB_Drawing_Board);
        textTool = new TextTool(BoardGraphics);
        zoomTool = new ZoomTool(PB_Drawing_Board);
        selectAreaTool = new SelectAreaTool();
    }

    public void Select_Color_From_Button(object sender, EventArgs e)
    {
        Button? selectedButton = sender as Button;
        if (Color_Picker.ShowDialog() == DialogResult.OK)
        {
            selectedButton.BackColor = Color_Picker.Color;
            switch (selectedButton.Tag)
            {
                case "PrimaryColor":
                    primaryColor = Color_Picker.Color; break;
                case "SecondaryColor":
                    secondaryColor = Color_Picker.Color; break;
            }
        }
    }

    /// <summary>
    /// Get drawing board size for status bar
    /// </summary>
    private void PB_Drawing_Board_SizeChanged(object sender, EventArgs e)
    {
        Lbl_Page_Size.Text = string.Format(format: "{0} {1}", PB_Drawing_Board.Width, PB_Drawing_Board.Height);
        PB_Ruler_Left.Height = PB_Drawing_Board.Height;
        PB_Ruler_Top.Width = PB_Drawing_Board.Width;
        BoxWithGrid.Size = PB_Drawing_Board.Size;
    }

    private void Btn_Open_File_Click(object sender, EventArgs e)
    {
        PB_Drawing_Board.OpenImage(this);
        zoomTool = new ZoomTool(PB_Drawing_Board);
    }

    /// <summary>
    /// Set visible of Ruler in drawing board
    /// </summary>
    private void ToggleRuler()
    {
        IsRulerOpen = !IsRulerOpen;
        PB_Ruler_Left.Visible = IsRulerOpen;
        PB_Ruler_Top.Visible = IsRulerOpen;

        PB_Drawing_Board.Location = IsRulerOpen
            ? BuiltInCoordinates.NewDrawingBoardCoordinate
            : BuiltInCoordinates.OldDrawingBoardCoordinate;

        this.Size = IsRulerOpen
            ? BuiltInCoordinates.RulerOpenedCoordinate
            : BuiltInCoordinates.RulerClosedCoordinate;
    }

    /// <summary>
    /// Get mouse positions for status bar
    /// </summary>
    private void PB_Drawing_Board_MouseMove(object sender, MouseEventArgs e)
    {
        Lbl_Mouse_Coordinates.Text = string.Format("{0} , {1} px", e.X, e.Y);
        if (IsMouseDown == true)
        {
            switch (currentTool)
            {
                case DrawingTool.Pen:
                    if (lastPoint != null)
                    {
                        penTool.Location = e.Location;
                        penTool.BackColor = primaryColor;
                        penTool.LastPoint = lastPoint;
                        penTool.Handle();
                        lastPoint = e.Location;
                    }
                    break;
                case DrawingTool.Eraser:
                    if (lastPoint != null)
                    {
                        eraserTool.Location = e.Location;
                        eraserTool.LastPoint = lastPoint;
                        eraserTool.Handle();
                        lastPoint = e.Location;
                    }
                    break;
                case DrawingTool.Select_Area:
                    if (e.Button != MouseButtons.Left)
                    {
                        break;
                    }

                    selectAreaTool.SelectedArea = new Rectangle(
                        Math.Min(StartPoint.X, e.Location.X),
                        Math.Min(StartPoint.Y, e.Location.Y),
                        Math.Abs(StartPoint.X - e.Location.X),
                        Math.Abs(StartPoint.Y - e.Location.Y));
                    //Preview _shape and rubber band box
                    using (Graphics g = PB_Drawing_Board.CreateGraphics())
                    {
                        g.DrawRectangle(Pens.Red, selectAreaTool.SelectedArea);
                        var shape = ShapeFactory.Create(currentShape.Value);
                        if (currentShape != null && selectAreaTool.SelectedArea.Width > 1)
                        {
                            if (ShapeOptions.IsFilled == true)
                            { 
                                shape.Fill(g, selectAreaTool.SelectedArea, new SolidBrush(primaryColor));
                            }
                            else
                            {
                                shape.Draw(g, selectAreaTool.SelectedArea, new Pen(primaryColor, ShapeOptions.BorderSize));
                            }
                        }
                    }
                    break;
            }
            PB_Drawing_Board.Refresh();
        }
        //_undoRedoManager.Execute((Image)PB_Drawing_Board.Image.Clone());
    }

    private void PB_Drawing_Board_MouseDown(object sender, MouseEventArgs e)
    {
        IsMouseDown = true;
        lastPoint = e.Location;
        //_undoRedoManager.Execute((Image)PB_Drawing_Board.Image.Clone());
        switch (currentTool)
        {
            case DrawingTool.Color_Picker:
                colorPickerTool.Location = e.Location;
                colorPickerTool.Handle();
                primaryColor = colorPickerTool.DetectedColor;
                break;
            case DrawingTool.Text:
                textTool.Location = e.Location;
                textTool.ForeColor = primaryColor;
                textTool.SideColor = secondaryColor;
                textTool.Text = Txt_Text.Text;
                textTool.Font = Font_Dialog.Font;
                textTool.Handle();
                PB_Drawing_Board.Refresh();
                break;
            case DrawingTool.Zoom:
                if (e.Button == MouseButtons.Left)
                    ZoomToImage(ZoomStatus.ZoomIn);
                else if (e.Button == MouseButtons.Right)
                    ZoomToImage(ZoomStatus.ZoomOut);
                break;
            case DrawingTool.Select_Area:
                if (e.Button == MouseButtons.Left)
                {
                    Cursor = Cursors.Cross;
                    StartPoint = e.Location;
                }
                PB_Drawing_Board.Refresh();
                break;
        }
    }

    private void PB_Drawing_Board_MouseUp(object sender, MouseEventArgs e)
    {
        if (currentTool == DrawingTool.Select_Area)
        {
            if (currentShape != null && selectAreaTool.SelectedArea.Width > 1)
            {
                var shape = ShapeFactory.Create(currentShape.Value);
                //_undoRedoManager.Execute((Image)PB_Drawing_Board.Image.Clone());
                if (ShapeOptions.IsFilled == true)
                {
                    shape.Fill(BoardGraphics, selectAreaTool.SelectedArea, new SolidBrush(primaryColor));
                }
                else
                {
                    shape.Draw(BoardGraphics, selectAreaTool.SelectedArea, new Pen(primaryColor, ShapeOptions.BorderSize));
                }
                selectAreaTool.Clear();
            }
        }
        lastPoint = e.Location;
        IsMouseDown = false;
        PB_Drawing_Board.Refresh();
    }

    /// <summary>
    /// Get tool name with sender func
    /// </summary>
    /// <param name="sender">Any Prologue Tool</param>
    /// <param name="e">Event Args</param>
    private void Select_Tool(object sender, EventArgs e)
    {
        List<Button> buttonArr = new List<Button>
        {
            Btn_Pen,
            Btn_Erase,
            Btn_Zoom,
            Btn_Color_Picker,
            Btn_Add_Text,
            Btn_Paint_All,
            Btn_Select_Area
        };
        buttonArr.ForEach(p => p.BackColor = MenuSettings.DefaultToolColor);
        Button? btn = sender as Button;

        //Select drawing tool by sender's tag
        currentTool = (DrawingTool)Enum.Parse(typeof(DrawingTool), btn!.Tag.ToString());
        btn.BackColor = MenuSettings.CurrentToolColor;

        //Toggle Text Tab
        if (currentTool == DrawingTool.Text)
        {
            TC_Menu.TabPages.Add(TP_Text);
            TC_Menu.SelectedTab = TP_Text;
        }
        else
            TC_Menu.TabPages.Remove(TP_Text);
    }
    private void Check_Gridlines_Before_Save(Action SaveAction)
    {
        ZoomToImage(ZoomStatus.ZoomToNormal);
        if (CB_Guidelines.Checked)
            BoxWithGrid.Visible = false;
        SaveAction();
        if (CB_Guidelines.Checked)
            BoxWithGrid.Visible = true;
    }
    private void Save_Image(object sender, EventArgs e)
    {
        Check_Gridlines_Before_Save(() =>
        {
            PictureBox? pictureBox = sender as PictureBox;
            switch (pictureBox.Name)
            {
                case nameof(PB_Save_As_GIF):
                    PB_Drawing_Board.SaveImage(ImageFormat.Gif); 
                    break;
                case nameof(PB_Save_As_JPG):
                    PB_Drawing_Board.SaveImage(ImageFormat.Jpeg);
                    break;
                case nameof(PB_Save_As_PNG):
                    PB_Drawing_Board.SaveImage(ImageFormat.Png); 
                    break;
                default: PB_Drawing_Board.SaveImage(); break;
            }
        });
    }

    /// <summary>
    /// Detect changed variables and run some processes
    /// </summary>
    private void Continuous_Checker_Tick(object sender, EventArgs e)
    {
        Btn_Text_Primary_Color.BackColor = primaryColor;
        Btn_Primary_Color.BackColor = primaryColor;
        Btn_Text_Secondary_Color.BackColor = secondaryColor;
        Btn_Secondary_Color.BackColor = secondaryColor;
    }

    private void UpdateGraphics()
    {
        PB_Drawing_Board.Refresh();
        BoardGraphics = Graphics.FromImage((Bitmap)PB_Drawing_Board.Image);
        penTool = new PenTool(BoardGraphics);
        eraserTool = new EraserTool(BoardGraphics);
        textTool = new TextTool(BoardGraphics);
    }

    //Shortcut Helper method
    private void Detect_Key(object sender, KeyEventArgs e)
    {
        if (e.Modifiers == Keys.Control)
        {
            switch (e.KeyCode)
            {
                case Keys.S:
                    Check_Gridlines_Before_Save(() => { PB_Drawing_Board.SaveImage(); });
                    break;
                case Keys.R:
                    ToggleRuler();
                    break;
                case Keys.G:
                    BoxWithGrid.Visible = !BoxWithGrid.Visible;
                    break;
                case Keys.O:
                case Keys.N:
                    PB_Drawing_Board.OpenImage(this);
                    zoomTool = new ZoomTool(PB_Drawing_Board);
                    break;
                case Keys.P:
                    PB_Drawing_Board.PrintImage();
                    break;
                case Keys.Add:
                    penTool.IncreaseSize();
                    eraserTool.IncreaseSize();
                    break;
                case Keys.Subtract:
                    penTool.DescreaseSize();
                    eraserTool.DescreaseSize();
                    break;
            }
        }
    }

    private void Clipboard_Events(object sender, EventArgs e)
    {
        Button? btn = sender as Button;
        switch (btn.Name)
        {
            case nameof(Btn_Copy_To_Clipboard):
                Clipboard.SetText(Txt_Text.Text);
                break;
            case nameof(Btn_Cut_To_Clipboard):
                Clipboard.SetText(Txt_Text.Text);
                Txt_Text.Clear();
                break;
            case nameof(Btn_Paste_From_Clipboard):
                Txt_Text.Text = Clipboard.GetText();
                break;
        }
    }

    private void Resize_Modal_Show(object sender, EventArgs e)
    {
        using ResizeForm resizeForm = new ResizeForm(PB_Drawing_Board);
        resizeForm.ShowDialog();
        PB_Drawing_Board.Size = resizeForm.sourceBitmap.Size;
        PB_Drawing_Board.SetImage(resizeForm.sourceBitmap);
        UpdateGraphics();

    }

    private void CB_Status_Bar_CheckedChanged(object sender, EventArgs e)
    {
        Status_Bar.Visible = CB_Status_Bar.Checked;
    }

    private void CB_Guidelines_CheckedChanged(object sender, EventArgs e)
    {
        BoxWithGrid.Visible = !BoxWithGrid.Visible;
    }

    private void PB_Font_Dialog_Click(object sender, EventArgs e)
    {
        Font_Dialog.ShowDialog();
    }

    private void CB_Ruler_CheckedChanged(object sender, EventArgs e)
    {
        ToggleRuler();
    }

    private void Btn_Print_Image_Click(object sender, EventArgs e)
    {
        PB_Drawing_Board.PrintImage();
    }

    private void Btn_New_Image_Click(object sender, EventArgs e)
    {
        PB_Drawing_Board.NewImage(this);
    }

    private void Btn_Zoom_In_Click(object sender, EventArgs e)
    {
        ZoomToImage(ZoomStatus.ZoomIn);
    }

    private void Btn_Zoom_Out_Click(object sender, EventArgs e)
    {
        ZoomToImage(ZoomStatus.ZoomOut);
    }

    private void Btn_Zoom_Normal_Click(object sender, EventArgs e)
    {
        ZoomToImage(ZoomStatus.ZoomToNormal);
    }

    private void ZoomToImage(ZoomStatus status)
    {
        switch (status)
        {
            case ZoomStatus.ZoomIn: zoomTool.ZoomIn(); break;
            case ZoomStatus.ZoomOut: zoomTool.ZoomOut(); break;
            case ZoomStatus.ZoomToNormal: zoomTool.ZoomToNormal(); break;
        }
        zoomTool.Handle();
        PB_Drawing_Board.SetImage(zoomTool.ZoomedImage);
        UpdateGraphics();
    }

    private void Btn_Features_Click(object sender, EventArgs e)
    {
        using FeaturesForm featuresForm = new FeaturesForm(PB_Drawing_Board,
            new ImageInformation(
                (int)((Bitmap)PB_Drawing_Board.Image).HorizontalResolution));
        featuresForm.ShowDialog();
        PB_Drawing_Board.Size = featuresForm.sourceBitmap.Size;
        PB_Drawing_Board.SetImage(featuresForm.sourceBitmap);
        UpdateGraphics();
    }

    private void Btn_Rotate_Image_Click(object sender, EventArgs e)
    {
        Bitmap rotatedImg = (Bitmap)PB_Drawing_Board.Image;
        rotatedImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
        PB_Drawing_Board.SetImage(rotatedImg);
        UpdateGraphics();
    }

    private void Select_Shape(object sender, EventArgs e)
    {
        PictureBox? pb = sender as PictureBox;
        currentShape = (GeometricalShape)Enum.Parse(typeof(GeometricalShape), pb!.Tag.ToString());
        currentTool = DrawingTool.Select_Area;
    }

    private void CB_Shape_Fill_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShapeOptions.IsFilled = CB_Shape_Fill.SelectedIndex == 1;
    }

    private void CB_Shape_Corner_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShapeOptions.BorderStatus = (ShapeBorderStatus)CB_Shape_Border.SelectedIndex;
    }

    private void PB_Drawing_Board_MouseClick(object sender, MouseEventArgs e)
    {
        switch (currentTool)
        {
            case DrawingTool.Filler:
                fillerTool.TargetColor = primaryColor;
                fillerTool.ReplacementColor = secondaryColor;
                fillerTool.Location = e.Location;
                fillerTool.Handle();
                break;
        }
    }
}
