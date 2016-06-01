using System;

namespace PushSchool.Kernel.Core.ValueObjects
{
    public class Entidade
    {
        public Guid Id { get; private set; }

        public Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
