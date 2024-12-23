﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Sitko.Abstract
{
    public interface IRepository<T>
    {
        public IEnumerable<T> ReadList();
        public void Create(T entity);
        public T Read(long? Id);
        public void Update(T entity);
        public void Delete(long id);
    }
}
