using AutoMapper;
using AutoMapper.QueryableExtensions;
using AzMPA101Api.Data;
using AzMPA101Api.Dto;
using AzMPA101Api.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzMPA101Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(
    AppDbContext dbContext, 
    IMapper mapper, 
    IValidator<ProductCreateDto> productValidator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var datas = await dbContext.Products
            .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
            .ToListAsync();
        return Ok(datas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await dbContext.Products
            .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(x => x.Id == id);
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCreateDto newProductDto)
    {
        var result = productValidator.Validate(newProductDto);
        if (!result.IsValid)
        {
            return BadRequest(result.Errors.Select(e => new
            {
                Property = e.PropertyName,
                Error = e.ErrorMessage
            }));
        }
        Product newProduct = mapper.Map<Product>(newProductDto);
        await dbContext.Products.AddAsync(newProduct);
        await dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int? id)
    {
        if (id is null) return BadRequest();
        Product? product = dbContext.Products.FirstOrDefault(x => x.Id == id);
        if(product is null) return NotFound();
        dbContext.Products.Remove(product);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(int? id, Product updateProduct)
    {
        if (id is null) return BadRequest();
        Product? product = dbContext.Products.FirstOrDefault(x => x.Id == id);
        if (product is null) return NotFound();
        product.Name = updateProduct.Name;
        product.Price = updateProduct.Price;
        product.Category = updateProduct.Category;
        return Ok();
    }
}