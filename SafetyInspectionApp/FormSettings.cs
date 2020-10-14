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

        public int FORM_HEIGHT { get => fORM_HEIGHT; set => fORM_HEIGHT = value; }
        public int FORM_MIN_WIDTH { get => fORM_MIN_WIDTH; set => fORM_MIN_WIDTH = value; }
        public int FORM_MAX_WIDTH { get => fORM_MAX_WIDTH; set => fORM_MAX_WIDTH = value; }
    }
}
