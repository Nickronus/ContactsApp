using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ContactsApp.View
{
    public class ContactsAppColors
    {
        /// <summary>
        /// Цвет при наличии ошибки.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет при отсутствии ошибки.
        /// </summary>
        public static Color AllOkColor = Color.White;

        /// <summary>
        /// Цвет при наведении курсора.
        /// </summary>
        public static Color MouseEnter = ColorTranslator.FromHtml("#F5F5FF");

        /// <summary>
        /// Цвет при уведении курсора.
        /// </summary>
        public static Color MouseLeave = Color.White;
    }
}
