using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonsClass
{
    public class Buttons
    {
        /// <summary>
        /// Aumenta le dimensioni dell'Icona specificata nel sender.
        /// </summary>
        /// <param name="sender">Icona da modificare</param>
        public static void HoverAnimation(object sender)
        {
            PictureBox p = (PictureBox)sender;
            p.Size = new Size(p.Size.Width + 2, p.Size.Height + 2);
            p.Location = new Point(p.Location.X - 1, p.Location.Y - 1);
        }
        /// <summary>
        /// Diminuisce le dimensioni dell'Icona specificata.
        /// </summary>
        /// <param name="sender">Icona da modificare</param>
        public static void LeaveAnimation(object sender)
        {
            PictureBox p = (PictureBox)sender;
            p.Size = new Size(p.Size.Width - 2, p.Size.Height - 2);
            p.Location = new Point(p.Location.X + 1, p.Location.Y + 1);
        }
        /// <summary>
        /// Chiude il Thread principale.
        /// </summary>
        public static void closeEvent()
        {
            Application.Exit();
        }
        /// <summary>
        /// Riduce ad icona un Form.
        /// </summary>
        /// <param name="form">Form</param>
        public static void minimizeEvent(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

    }
}
