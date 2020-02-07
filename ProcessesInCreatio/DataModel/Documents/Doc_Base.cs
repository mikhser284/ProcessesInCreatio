using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel.Documents
{
    /// <summary> Базовый тип документа </summary>
    public class Doc_Base : IExtendedEntity
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

        /// <summary> № версии документа </summary>
        public Int32 VersionNo { get; set; }

        /// <summary> Название документа </summary>
        public String Name { get; set; }

        /// <summary> Файл документа </summary>
        public File_Base FileOfDocument { get; set; }

        /// <summary> Вложения с файлами </summary>
        public ICollection<File_Base> AttachmentsWithFiles { get; set; }

        /// <summary> Вложения с документами </summary>
        public ICollection<Doc_Base> AttachmentsWithDocuments { get; set; }        
    }
}
