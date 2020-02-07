using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel
{
    public interface IExtendedEntity : IEntity
    {
        /// <summary> Время создания </summary>
        DateTime CreatedAt { get; }

        /// <summary> Автор </summary>
        User CreatedBy { get; }

        /// <summary> Время обновления </summary>
        DateTime UpdatedAt { get; }

        /// <summary> Автор изменений </summary>
        User UpdatedBy { get; }
    }
}
