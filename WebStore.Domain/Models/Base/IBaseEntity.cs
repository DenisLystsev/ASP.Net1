﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Models.Base
{
    public interface IBaseEntity
    {
        //Идентификатор
        int Id { get; set; }
    }
}