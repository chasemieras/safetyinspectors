using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public class FormSettings
    {

        public IList<Object> controlsDataList = new List<Object>();

        private static int fORM_HEIGHT = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
        private static int fORM_WIDTH = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;

        private static int gROUPING_HEIGHT = 440;
        private static int gROUPING_WIDTH = 450;

        private static string[] kEY_WORDS_FOR_FORM_SELECTION = { "LADDER" };

        private static string kEY_WORD_FOR_FORM = "";

        public int FORM_HEIGHT { get => fORM_HEIGHT; }
        public int FORM_WIDTH { get => fORM_WIDTH; }

        public int GROUPING_HEIGHT { get => gROUPING_HEIGHT; }
        public int GROUPING_WIDTH { get => gROUPING_WIDTH; }
        public string[] KEY_WORDS_FOR_FORM_SELECTION { get => kEY_WORDS_FOR_FORM_SELECTION; }
        public string KEY_WORD_FOR_FORM { get => kEY_WORD_FOR_FORM; set => kEY_WORD_FOR_FORM = value; }
    }
}
