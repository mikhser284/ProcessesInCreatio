using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel
{
    public class Person
    {
        /// <summary> Идентификатор объекта </summary>
        public Int32 Id { get; private set; }

        /// <summary> Дата рождения </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary> Имя </summary>
        public String FirstName { get; set; }

        /// <summary> Отчество </summary>
        public String MiddleName { get; set; }

        /// <summary> Фамилия </summary>
        public String LastName { get; set; }
    }
}
