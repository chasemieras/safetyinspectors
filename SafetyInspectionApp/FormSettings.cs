using System;
using System.Collections.Generic;
using System.Text;

namespace SafetyInspectionApp
{
    public class FormSettings
    {
        private static int fORM_HEIGHT = 515;
        private static int fORM_MIN_WIDTH = 750;
        private static int fORM_MAX_WIDTH = 900;

        private static int gROUPING_HEIGHT = 440;
        private static int gROUPING_WIDTH = 450;

        private static string[] kEY_WORDS_FOR_FORM_SELECTION = { "LADDER" };

        public int FORM_HEIGHT { get => fORM_HEIGHT; }
        public int FORM_MIN_WIDTH { get => fORM_MIN_WIDTH; }
        public int FORM_MAX_WIDTH { get => fORM_MAX_WIDTH; }

        public int GROUPING_HEIGHT { get => gROUPING_HEIGHT; }
        public int GROUPING_WIDTH { get => gROUPING_WIDTH; }
        public string[] KEY_WORDS_FOR_FORM_SELECTION { get => kEY_WORDS_FOR_FORM_SELECTION; }

    }
}
