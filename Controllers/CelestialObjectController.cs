﻿using System;

namespace AspNetCoreWebAPIStarChart.Controllers

            if ((celestialObjects == null)|| (celestialObjects.Count == 0))

            if ((celestialObjs == null) || (celestialObjs.Count == 0))
        [Produces("application/json")]
        public IActionResult Create([FromBody]CelestialObject celestialObject)
        [Produces("application/json")]
        public IActionResult Update([FromBody]CelestialObject celestialObject)
                     

            return Ok("CelestilObject Deleted Succsessfuly!!!");