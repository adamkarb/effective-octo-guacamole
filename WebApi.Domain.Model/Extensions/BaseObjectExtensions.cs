using System;
using System.Threading.Tasks;

namespace WebApi.Domain.Model.Extensions
{
    public static class BaseObjectExtensions
    {
        public static Task<BaseObject> ToTask(this BaseObject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            return Task.FromResult(obj);
        }
    }
}
