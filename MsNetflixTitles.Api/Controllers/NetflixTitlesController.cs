using Microsoft.AspNetCore.Mvc;
using MsNetflixTitles.Application.Repositories;
using MsNetflixTitles.Application.Services;
using MsNetflixTitles.CrossCutting.Dtos;
using System.Net;
using System.Threading.Tasks;

namespace MsNetflixTitles.Api.Controllers
{
    [Route("netflix-titles")]
    public class NetflixTitlesController : ControllerBase
    {
        private readonly INetflixTitlesRepository _netflixTitlesRepository;
        private readonly ICreateNetflixTitleServices _createNetflixTitleServices;

        public NetflixTitlesController(INetflixTitlesRepository netflixTitlesRepository,
            ICreateNetflixTitleServices createNetflixTitleServices)
        {
            _netflixTitlesRepository = netflixTitlesRepository;
            _createNetflixTitleServices = createNetflixTitleServices;
        }

        [Route("get-by-country")]
        [HttpGet]
        [ProducesResponseType(typeof(DirectorsByCountryDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetByCountry(string countryName)
            => Ok(await _netflixTitlesRepository.GetDirectorsByCountry(countryName));

        [HttpPost]
        [ProducesResponseType(typeof(NetflixTitleDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Post(NetflixTitleDto dto)
            => Ok(await _createNetflixTitleServices.Create(dto));
    }
}