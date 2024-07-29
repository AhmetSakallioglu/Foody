﻿using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Concrete;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
	public class EfSliderDal : GenericRepository<Slider>, ISliderDal
	{
		public EfSliderDal(FoodyContext context) : base(context)
		{
		}
	}
}