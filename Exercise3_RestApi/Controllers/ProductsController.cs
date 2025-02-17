using Exercise3_RestApi.Models;
using Exercise3_RestApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Exercise3_RestApi.Validators;
using FluentValidation.Results;

namespace Exercise3_RestApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly ProductsDataStore _productsDataStore;

        public ProductsController(ILogger<ProductsController> logger, ProductsDataStore productsDataStore)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productsDataStore = productsDataStore ?? throw new ArgumentNullException(nameof(productsDataStore));
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                return Ok(_productsDataStore.Products);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString(), ex);
                return StatusCode(500, "The request encountered a problem");
            }
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public ActionResult<ProductDto> GetProduct(int id)
        {
            try
            {
                var productToReturn = _productsDataStore.Products.FirstOrDefault(x => x.Id == id);
                if (productToReturn == null)
                {
                    _logger.LogInformation($"Product with id {id} wasn't found when accessing Products");
                    return NotFound();
                }
                return Ok(productToReturn);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Exception while getting product with id {id}.", ex);
                return StatusCode(500, "The request encountered a problem");
            }
            
        }

        [HttpPost]
        public ActionResult<ProductDto> AddProduct([FromBody] Product product)
        {
            try
            {
                ProductValidator validator = new ProductValidator();
                ValidationResult result = validator.Validate(product);
                if (!result.IsValid)
                {
                    return BadRequest(result.ToString());
                }
                var maxProductId = _productsDataStore.Products.Max(p => p.Id);
                var newProduct = new ProductDto()
                {
                    Id = ++maxProductId,
                    Name = product.Name,
                    Description = product.Description
                };
                _productsDataStore.Products.Add(newProduct);
                return CreatedAtRoute("GetProduct", new { id = newProduct.Id }, newProduct);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString(), ex);
                return StatusCode(500, "The request encountered a problem");
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            try
            {
                var existingProduct = _productsDataStore.Products.FirstOrDefault(p => p.Id == id);
                if (existingProduct == null)
                {
                    return NotFound();
                }
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString(), ex);
                return StatusCode(500, "The request encountered a problem");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                var existingProduct = _productsDataStore.Products.FirstOrDefault(p => p.Id == id);
                if (existingProduct == null)
                {
                    return NotFound();
                }
                _productsDataStore.Products.Remove(existingProduct);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString(), ex);
                return StatusCode(500, "The request encountered a problem");
            }
        }
    }
}
