using ApiProjectKampi.WebApi.Context;
using ApiProjectKampi.WebApi.Dtos.ProductDtos;
using ApiProjectKampi.WebApi.Entities;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProjectKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IValidator<Product> _validator;
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public ProductController(IValidator<Product> validator, ApiContext context, IMapper mapper)
        {
            _validator = validator;
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _context.Products.ToList();
            return Ok(value);

        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok("Product succesfully added");
            }


        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Products.Remove(value);
            _context.SaveChanges();
            return Ok("Product successfully deleted");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _context.Products.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            else
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return Ok("Product succesfully updated");
            }

        }
        [HttpPost("AddProductWCategory")]
        public IActionResult AddProductWCategory(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            _context.Products.Add(value);
            _context.SaveChanges();
            return Ok("Product successfully added with category");

        }
        [HttpGet("GetProductWCategory")]
        public IActionResult GetProductWCategory(int id)
        {
            var value = _context.Products.Include(x=>x.category).ToList();
            return Ok(_mapper.Map<List<ResultProductWCategoryDto>>(value));
        }
    }
}
