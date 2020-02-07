using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel.Nomenclature
{
    /// <summary> Единица измерения </summary>
    public class UnitOfMeasure : IExtendedEntity
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

        /// <summary> Краткое название единицы измерения </summary>
        public String ShortName { get; set; }

        /// <summary> Полное название единицы измерения </summary>
        public String FullName { get; set; }

        /// <summary> Группа единиц измерения </summary>
        public MeasureUnintsGroup Group { get; set; }
    }
}
