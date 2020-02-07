using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel
{
    public class NomenclatureGroup : IExtendedEntity
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

        /// <summary> Родительская группа </summary>
        public NomenclatureGroup ParentGroup { get; private set; }

        /// <summary> Название </summary>
        public String Name { get; set; }
    }
}
