using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel
{
    public interface IDuplicableEntity
    {
        /// <summary> Уникальный идентификатор в основной БД </summary>
        String UniqueIdInPrimaryDB { get; set; }

        /// <summary> Является ли данный объект дубликатом </summary>
        Boolean? IsDuplicate { get; set; }

        /// <summary> Дублируемый объект </summary>
        IDuplicableEntity DuplicateOf { get; set; }
    }
}
