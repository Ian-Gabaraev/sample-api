using FaceList.Models;
using FaceList.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FaceList.Controllers
{
    [Route("api/faces")]
    [ApiController]
    public class FaceController: ControllerBase
    {
        private readonly FaceListService _faceService;

        public FaceController(FaceListService faceService)
        {
            _faceService = faceService;
        }

        [HttpGet]
        public ActionResult<List<Face>> Get() =>
            _faceService.Get();

        [HttpGet("{id:length(24)}", Name = "GetFace")]
        public ActionResult<Face> Get(string id)
        {
            var face = _faceService.Get(id);

            if (face == null)
            {
                return NotFound();
            }

            return face;
        }
    }
}