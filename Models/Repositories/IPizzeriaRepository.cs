﻿using la_mia_pizzeria_static.Models.Form;

namespace la_mia_pizzeria_static.Models.Repositories
{
    public interface IPizzeriaRepository
    {
        List<Pizza> All();
        //List<Category> GetCategories();
        //List<Ingredient> GetIngredients();
        //l ' entità per essere creata di cosa ha bisogno?
        void Create(Pizza pizza, List<int> SelectedIngredients);
        Pizza GetById(int id);
        void Update(Pizza pizza, Pizza formData, List<int>? SelectedIngredients);
        void Delete(Pizza pizza);

    }
}