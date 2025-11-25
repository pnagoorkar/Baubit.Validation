using FluentResults;

namespace Baubit.Validation
{
    public interface IValidator<T>
    {
        Result Run(T validatable);
    }
}
