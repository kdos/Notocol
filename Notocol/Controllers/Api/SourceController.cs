﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Notocol.Models;
using Repository;

namespace Notocol.Controllers.Api
{
    public class SourceController : BaseApiController
    {
        [HttpGet]
        public IList<Source> Source()
        {
            SourceRepository obSourceRepository = new SourceRepository();
            return  obSourceRepository.GetSource(2);
        }

        /// <summary>
        /// Save Source and its related Tag(s)
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        [HttpPost]
        public long Add([FromBody]SourceTagRequest source)
        {
            SourceRepository obSourceRepository = new SourceRepository();
            obSourceRepository.SaveSource(source.Source, source.Tags);
            return source.Source.ID;
        }


    }
}
