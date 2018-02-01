﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;

namespace BackgroundJobAndNotificationsDemo.Emailing.Dto
{
    public class SendPrivateEmailInput : EntityDto
    {
        [Required]
        [MaxLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }
        
        [Required]
        [MaxLength(128)]
        public string Subject { get; set; }
        
        [Required]
        [MaxLength(4000)]
        public string Body { get; set; }

        public bool SendNotification { get; set; }
    }
}