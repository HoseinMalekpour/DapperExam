using DapperExam.Core.dto;
using DapperExam.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DapperExamController : ControllerBase
    {
        private IProductRepository productRepository;

        public DapperExamController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            return productRepository.GetAllProduct();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return productRepository.GetProductById(id);
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            productRepository.AddProduct(product);
            return Ok(product);
        }

    }
}
