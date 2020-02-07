using System;
using System.Collections.Generic;
using System.Text;
using ProcessesInCreatio.DataModel.Nomenclature;

namespace ProcessesInCreatio.DataModel
{
    /// <summary> Номенклатурная единица </summary>
    public class NomenclatureItem : IExtendedEntity, IDuplicableEntity
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

        #region ————— IDuplicableEntity ———————————————————————————————————————————————————————————————————————————————

        /// <summary> Уникальный идентификатор в основной БД </summary>
        public String UniqueIdInPrimaryDB { get; set; }

        /// <summary> Является ли данный объект дубликатом </summary>
        public Boolean? IsDuplicate { get; set; }

        /// <summary> Дублируемый объект </summary>
        public IDuplicableEntity DuplicateOf { get; set; }

        #endregion ————— IDuplicableEntity

        /// <summary> Краткое название номенклатурной единицы </summary>
        public String ShortName { get; set; }

        /// <summary> Полное название номенклатурной единицы </summary>
        public String FullName { get; set; }

        /// <summary> Единица измерения </summary>
        public UnitOfMeasure MeasureUnit { get; set; } 

        
    }
}
