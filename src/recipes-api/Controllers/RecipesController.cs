using Microsoft.AspNetCore.Mvc;
using recipes_api.Services;
using recipes_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace recipes_api.Controllers;

[ApiController]
[Route("recipe")]
public class RecipesController : ControllerBase
{
    public readonly IRecipeService _service;

    public RecipesController(IRecipeService service)
    {
        this._service = service;
    }

    // 1 - Sua aplicação deve ter o endpoint GET /recipe
    //Read
    [HttpGet]
    public IActionResult Get()
    {
        var recipes = _service.GetRecipes();
        if (recipes == null)
        {
            return NotFound("0 recipes found");
        }
        return Ok(recipes);
    }

    // 2 - Sua aplicação deve ter o endpoint GET /recipe/:name
    //Read
    [HttpGet("{name}", Name = "GetRecipe")]
    public IActionResult Get(string name)
    {
        var recipeName = _service.GetRecipe(name);
        if (recipeName == null)
        {
            return NotFound($"The recipe {recipeName} was not found");
        }
        return Ok(recipeName);
    }

    // 3 - Sua aplicação deve ter o endpoint POST /recipe
    [HttpPost]
    public IActionResult Create([FromBody] Recipe recipe)
    {
        if (recipe == null)
        {
            return BadRequest();
        }
        _service.AddRecipe(recipe);

        return StatusCode(201, recipe);

    }

    // 4 - Sua aplicação deve ter o endpoint PUT /recipe
    [HttpPut("{name}")]
    public IActionResult Update(string name, [FromBody] Recipe recipe)
    {

        if (name == null || !_service.RecipeExists(recipe.Name))
        {
            return BadRequest();
        }
        _service.UpdateRecipe(recipe);

        return NoContent();

    }

    // 5 - Sua aplicação deve ter o endpoint DEL /recipe
    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        if (name == null || !_service.RecipeExists(name))
        {
            return NotFound();
        }
        _service.DeleteRecipe(name);

        return NoContent();
    }
}
