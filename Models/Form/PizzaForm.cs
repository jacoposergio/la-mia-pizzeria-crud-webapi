﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace la_mia_pizzeria_static.Models.Form
{
    public class PizzaForm
    {
        //Model del db e delle views: per la creazione di create,read, update
        public Pizza Pizza { get; set; }

        //questa classe è a contorno, ci serve per fare cose nella views
        //è opzionale perchè in fase di validazione mi devo occupare solo del db
        //lamiapizzeriastatic lista serve solo per la parte grafica
        public List<Category>? Categories { get; set; } 

        public List<SelectListItem>? Ingredients { get; set; }  //oggetto di appoggio che serve per gestire le option nel create (asp-items)
        //create
        public List<int>? SelectedIngredients { get; set; }
    }
}
