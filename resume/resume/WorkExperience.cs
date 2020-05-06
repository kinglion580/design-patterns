using System;
using System.Collections.Generic;
using System.Text;

namespace resume
{
    class WorkExperience
    {
        private string workDate;
        public string WorkDate
        {
            get { return workDate;  }
            set { workDate = value;  }
        }
        private string company;
        public string Company
        {
            get { return company;  }
            set { company = value;  }
        }
    }
}
