using System;
using Microsoft.EntityFrameworkCore;
using MinuteMeals.Ui.Mvc.Models;

namespace MinuteMeals.Ui.Mvc.Core
{
	public class MinuteMealsDbContext(DbContextOptions<MinuteMealsDbContext> options) : DbContext(options)
	{
		public DbSet<Recipe> Recipes => Set<Recipe>();
		public void Seed()
		{
			var recipes = new List<Recipe>
			{
				new Recipe
				{
					Name = "Spaghetti Carbonara",
					Ingredients = "Spaghetti, Bacon, Eggs, Parmesan Cheese, Black Pepper, Garlic, Olive Oil",
					Steps = "1. Cook spaghetti until al dente.\n2. In a pan, cook bacon until crispy.\n3. Whisk eggs and parmesan together.\n4. Combine spaghetti with bacon, remove from heat, and stir in egg mixture.\n5. Season with black pepper and serve.",
					CookingTimeInMinutes = 30
				},
				new Recipe
				{
					Name = "Chicken Stir-fry",
					Ingredients = "Chicken Breast, Bell Peppers, Broccoli, Soy Sauce, Garlic, Ginger, Sesame Oil, Rice",
					Steps = "1. Cook rice according to package instructions.\n2. Stir-fry garlic and ginger in sesame oil.\n3. Add sliced chicken and cook until browned.\n4. Add vegetables and soy sauce, stir-fry until tender.\n5. Serve over rice.",
					CookingTimeInMinutes = 25
				},
				new Recipe
				{
					Name = "Beef Tacos",
					Ingredients = "Ground Beef, Taco Seasoning, Onion, Garlic, Corn Tortillas, Lettuce, Tomato, Cheese, Salsa",
					Steps = "1. Brown ground beef with onions and garlic.\n2. Add taco seasoning and cook for another 5 minutes.\n3. Warm tortillas in a pan.\n4. Assemble tacos with beef, lettuce, tomato, cheese, and salsa.",
					CookingTimeInMinutes = 20
				},
				new Recipe
				{
					Name = "Margherita Pizza",
					Ingredients = "Pizza Dough, Tomato Sauce, Mozzarella Cheese, Fresh Basil, Olive Oil, Salt",
					Steps = "1. Preheat oven to 220°C (430°F).\n2. Roll out pizza dough and spread tomato sauce.\n3. Add slices of mozzarella and fresh basil.\n4. Drizzle with olive oil and season with salt.\n5. Bake for 15 minutes or until crust is golden.",
					CookingTimeInMinutes = 30
				},
				new Recipe
				{
					Name = "Grilled Salmon",
					Ingredients = "Salmon Fillets, Lemon, Garlic, Dill, Olive Oil, Salt, Pepper, Asparagus",
					Steps = "1. Preheat grill to medium-high heat.\n2. Season salmon with salt, pepper, garlic, dill, and lemon.\n3. Grill salmon for 5-6 minutes per side.\n4. Grill asparagus until tender.\n5. Serve with lemon wedges.",
					CookingTimeInMinutes = 20
				},
				new Recipe
				{
					Name = "Vegetable Curry",
					Ingredients = "Coconut Milk, Curry Paste, Onion, Garlic, Carrot, Bell Pepper, Zucchini, Chickpeas, Rice",
					Steps = "1. Cook rice according to package instructions.\n2. Sauté onion, garlic, and curry paste in a pan.\n3. Add vegetables and cook until tender.\n4. Pour in coconut milk and simmer for 10 minutes.\n5. Serve over rice.",
					CookingTimeInMinutes = 40
				},
				new Recipe
				{
					Name = "Chicken Caesar Salad",
					Ingredients = "Chicken Breast, Romaine Lettuce, Caesar Dressing, Parmesan, Croutons, Olive Oil, Garlic",
					Steps = "1. Season chicken and cook in olive oil until golden.\n2. Toss lettuce with Caesar dressing and parmesan.\n3. Slice chicken and place on top of the salad.\n4. Add croutons and extra parmesan if desired.",
					CookingTimeInMinutes = 25
				},
				new Recipe
				{
					Name = "Pancakes",
					Ingredients = "Flour, Baking Powder, Sugar, Milk, Egg, Butter, Maple Syrup",
					Steps = "1. Mix flour, baking powder, and sugar in a bowl.\n2. Whisk in milk, egg, and melted butter.\n3. Pour batter onto a hot griddle and cook until bubbles form.\n4. Flip and cook until golden brown.\n5. Serve with maple syrup.",
					CookingTimeInMinutes = 15
				},
				new Recipe
				{
					Name = "Shrimp Scampi",
					Ingredients = "Shrimp, Garlic, Butter, Lemon Juice, White Wine, Parsley, Pasta",
					Steps = "1. Cook pasta until al dente.\n2. Sauté garlic in butter until fragrant.\n3. Add shrimp, white wine, and lemon juice. Cook until shrimp turns pink.\n4. Toss with pasta and fresh parsley.",
					CookingTimeInMinutes = 30
				},
				new Recipe
				{
					Name = "Tomato Basil Soup",
					Ingredients = "Tomatoes, Onion, Garlic, Vegetable Broth, Fresh Basil, Olive Oil, Salt, Pepper, Cream",
					Steps = "1. Sauté onion and garlic in olive oil.\n2. Add chopped tomatoes and vegetable broth.\n3. Simmer for 20 minutes, then blend until smooth.\n4. Stir in fresh basil and cream.\n5. Season with salt and pepper.",
					CookingTimeInMinutes = 45
				}

			};
			Recipes.AddRange(recipes);

			SaveChanges();

		}
	}
}