namespace TheSmartPenguin
{
    using System;
    using System.Text;
    using TheSmartPenguin;
    public class ConsoleRender : IRenderer
    {
        int renderContextMatrixRows;
        int renderContextMatrixCols;
        char[,] renderContextMatrix;

        public ConsoleRender(int visibleConsoleRows, int visibleConsoleCols)
        {
            renderContextMatrix = new char[visibleConsoleRows, visibleConsoleCols];

            this.renderContextMatrixRows = renderContextMatrix.GetLength(0);
            this.renderContextMatrixCols = renderContextMatrix.GetLength(1);

            this.ClearQueue();
        }

        public void EnqueueForRendering(IRenderable obj)
        {
            char[,] objImage = obj.Shape;

            int imageRows = objImage.GetLength(0);
            int imageCols = objImage.GetLength(1);

            Coords objTopLeft = obj.Position;

            int lastRow = Math.Min(objTopLeft.Y + imageRows, this.renderContextMatrixRows);
            int lastCol = Math.Min(objTopLeft.X + imageCols, this.renderContextMatrixCols);

            for (int row = obj.Position.Y; row < lastRow; row++)
            {
                for (int col = obj.Position.X; col < lastCol; col++)
                {
                    if (row >= 0 && row < renderContextMatrixRows &&
                        col >= 0 && col < renderContextMatrixCols)
                    {
                        renderContextMatrix[row, col] = objImage[row - obj.Position.Y, col - obj.Position.X];
                    }
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);

            StringBuilder scene = new StringBuilder();

            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    scene.Append(this.renderContextMatrix[row, col]);
                }

                scene.Append(Environment.NewLine);
            }

            Console.WriteLine(scene.ToString());
        }

        public void ClearQueue()
        {
            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    this.renderContextMatrix[row, col] = ' ';
                }
            }
        }
    }
}
