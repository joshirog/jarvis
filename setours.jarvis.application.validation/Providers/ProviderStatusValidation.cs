﻿using FluentValidation;
using setours.jarvis.application.dto.Providers;

namespace setours.jarvis.application.validation.Providers
{
    public class ProviderStatusValidation : BaseValidation<ProviderStatusDto>
    {
        public ProviderStatusValidation()
        {
            RuleFor(d => d.Id).NotNull();
            RuleFor(d => d.Description).NotEmpty().WithMessage("Field description is required");
            RuleFor(d => d.Description).Length(5).WithMessage("Field description max length 5 characters");
        }
    }
}
