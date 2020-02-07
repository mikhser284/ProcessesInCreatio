using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel.Documents
{
    /// <summary> Базовый класс файла </summary>
    public class File_Base : IExtendedEntity
    {
        #region ————— IExtendedEntity —————————————————————————————————————————————————————————————————————————————————

        /// <summary> Идентификатор объекта </summary>
        public Int32 Id { get; private set; }

        /// <summary> Время создания </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary> Автор </summary>
        public User CreatedBy { get; private set; }

        /// <summary> Время обновления </summary>
        public DateTime UpdatedAt { get; private set; }

        /// <summary> Автор изменений </summary>
        public User UpdatedBy { get; private set; }

        #endregion ————— IExtendedEntity

        /// <summary> Название файла </summary>
        public String FileName { get;  set; }

        /// <summary> Расширение файла </summary>
        public String FileExtension { get; set; }

        /// <summary> Хеш файла </summary>
        public String FileHash { get; private set; }
    }
}
