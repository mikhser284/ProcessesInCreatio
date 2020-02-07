using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel
{
    public class Employee : Person
    {
        /// <summary> Дата начала карьеры </summary>
        public DateTime CarierStart { get; set; }

        /// <summary> Дата завершения карьеры </summary>
        public DateTime? CarierEnd { get; set; }

        /// <summary> Является ли внештатным сотрудником </summary>
        public Boolean IsFreelancer { get; set; }
    }
}
