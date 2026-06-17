using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FinalsHRApplicantProcessWindowsApplication.Forms.Applicant
{
    /// <summary>
    /// Draws small flat line-icons used next to the sidebar menu buttons.
    /// Generated at runtime so no image resources need to be added to the project.
    /// </summary>
    internal static class SidebarIcons
    {
        private const int CanvasWidth = 26;
        private const int CanvasHeight = 20;

        private static Bitmap CreateCanvas(Action<Graphics, Pen> draw, Color color)
        {
            Bitmap bmp = new Bitmap(CanvasWidth, CanvasHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            using (Pen pen = new Pen(color, 1.6f))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;
                draw(g, pen);
            }
            return bmp;
        }

        // Used on the Dashboard button
        public static Bitmap Home(Color color)
        {
            return CreateCanvas((g, pen) =>
            {
                // Roof
                g.DrawLines(pen, new Point[]
                {
                    new Point(2, 10),
                    new Point(9, 3),
                    new Point(16, 10)
                });

                // Walls
                g.DrawRectangle(pen, 4, 10, 10, 7);

                // Door
                g.DrawRectangle(pen, 8, 13, 3, 4);
            }, color);
        }

        // Used on the Job Vacancies button
        public static Bitmap Briefcase(Color color)
        {
            return CreateCanvas((g, pen) =>
            {
                // Handle
                g.DrawArc(pen, 8, 2, 6, 6, 180, 180);

                // Body
                g.DrawRectangle(pen, 3, 7, 14, 9);

                // Clasp line
                g.DrawLine(pen, 3, 11, 17, 11);
            }, color);
        }

        // Used on the Application Status button
        public static Bitmap Clipboard(Color color)
        {
            return CreateCanvas((g, pen) =>
            {
                // Board
                g.DrawRectangle(pen, 4, 3, 12, 15);

                // Clip
                g.DrawRectangle(pen, 8, 1, 4, 3);

                // Checklist lines
                g.DrawLine(pen, 6, 8, 12, 8);
                g.DrawLine(pen, 6, 11, 12, 11);
                g.DrawLine(pen, 6, 14, 12, 14);
            }, color);
        }

        // Used on the My Documents button
        public static Bitmap Folder(Color color)
        {
            return CreateCanvas((g, pen) =>
            {
                // Tab
                g.DrawLines(pen, new Point[]
                {
                    new Point(3, 7),
                    new Point(3, 5),
                    new Point(9, 5),
                    new Point(11, 7)
                });

                // Body
                g.DrawRectangle(pen, 3, 7, 16, 9);
            }, color);
        }

        // Used on the My Profile button
        public static Bitmap Person(Color color)
        {
            return CreateCanvas((g, pen) =>
            {
                // Head
                g.DrawEllipse(pen, 7, 2, 6, 6);

                // Shoulders
                g.DrawArc(pen, 3, 9, 14, 12, 180, 180);
            }, color);
        }
    }
}
