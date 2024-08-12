using System.Collections.Generic;

namespace MDBEditor.Utils;

public interface IUndoRedoManager<T>
{
    void Execute(Image newImage);
    void Undo();
    void Redo();

}

public class UndoRedoManager : IUndoRedoManager<Image>
{
    private Stack<Image> _undoStack = new Stack<Image>();
    private Stack<Image> _redoStack = new Stack<Image>();
    private bool CanUndo => _undoStack.Count > 0;
    private bool CanRedo => _redoStack.Count > 0;
    private PictureBox _pictureBox { get; set; }
    public UndoRedoManager(PictureBox pictureBox)
    {
        _pictureBox = pictureBox;
    }

    public void Execute(Image newImage)
    {
        // Add the current image to the undo stack
        if (_pictureBox.Image != null)
        {
            _undoStack.Push((Image)_pictureBox.Image.Clone());
        }

        // Apply the new image to the PictureBox
        _pictureBox.Image = newImage;

        // Clear the redo stack since a new action is taken
        _redoStack.Clear();

        _pictureBox.Refresh(); // Refresh the PictureBox to update the image    
    }

    public void Redo()
    {
        if (CanRedo)
        {
            // Add the current image to the undo stack
            if (_pictureBox.Image != null)
            {
                _undoStack.Push((Image)_pictureBox.Image.Clone());
            }

            // Pop the last image from the redo stack and apply it to the PictureBox
            _pictureBox.Image = _redoStack.Pop();
            _pictureBox.Refresh(); // Refresh the PictureBox to update the image
        }
    }

    public void Undo()
    {
        if (CanUndo)
        {
            // Add the current image to the redo stack
            if (_pictureBox.Image != null)
            {
                _redoStack.Push((Image)_pictureBox.Image.Clone());
            }

            // Pop the last image from the undo stack and apply it to the PictureBox
            _pictureBox.Image = _undoStack.Pop();
            _pictureBox.Refresh(); // Refresh the PictureBox to update the image
        }
    }
}
