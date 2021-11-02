using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Games_Ass1.Data
{
    class DrinksManager
    {
        public static List<Drink> GetDrinks()
        {
            var drinks = new List<Drink>();

            drinks.Add(new Drink
            {
                DrinkId = 1,
                Name = "Cosmopolitan",
                ImageName = "Assets/Drinks/Cosmopolitan.png",
                Recipe = "1.5 ounces of citrus vodka, 1 ounce of Cointreau, half an ounce of lime juice and a quarter of an ounce of cranberry juice.",
                Mix = "Put all the ingredients in a shaker with ice and shake. Strain into a martini glass and garnish with a lime wheel or zest."
            });
            drinks.Add(new Drink
            {
                DrinkId = 2,
                Name = "Whiskey Sour",
                ImageName = "Assets/Drinks/Whiskey Sour.png",
                Recipe = "2 ounces of whiskey, 1 ounce of lemon juice, 1 tablespoon of sugar and 1 egg white optional.",
                Mix = "Combine ingredients in a cocktail shaker and shake. Add ice and shake again. Strain over ice ina rocks glass"
            });
            drinks.Add(new Drink
            {
                DrinkId = 3,
                Name = "Daiquiri",
                ImageName = "Assets/Drinks/Daiquiri.png",
                Recipe = "2 ounces of light rum, 1 ounce of simple syrup and 1 ounces of lime juice.",
                Mix = "Shake ingredients with ice and strain into a cocktail glass. Garnish with a lime wheel."
            });
            drinks.Add(new Drink
            {
                DrinkId = 4,
                Name = "Dark n Stormy",
                ImageName = "Assets/Drinks/Dark n Stormy.png",
                Recipe = "Shake ingredients with ice and strain into a cocktail glass. Garnish with a lime wheel.",
                Mix = "Fill a highball glass with ice and add rum and ginger beer. Garnish with lime."
            });
            drinks.Add(new Drink
            {
                DrinkId = 5,
                Name = "French 75",
                ImageName = "Assets/Drinks/French 75.png",
                Recipe = "2 ounces of gin, 2 dashes of simple syrup, half an ounce of lemon juice and champagne.",
                Mix = "Shake gin, simple syrup, and lemon juice with ice. Strain into a champagne glass. Top with champagne."
            });
            drinks.Add(new Drink
            {
                DrinkId = 6,
                Name = "Manhattan",
                ImageName = "Assets/Drinks/Manhattan.png",
                Recipe = "2 ounces of rye whiskey, 1 ounce of sweet vermouth and 2 dashes of Angostura bitters.",
                Mix = "Stir ingredients in a mixing glass with ice. Strain into chilled martini glass or cocktail glass."
            });
            drinks.Add(new Drink
            {
                DrinkId = 7,
                Name = "Margarita",
                ImageName = "Assets/Drinks/Margarita.png",
                Recipe = "2 ounces of silver tequila, 1 ounce of Cointreau, 1 ounce of lime juice and salt for the glass rim.",
                Mix = "It should be shaken, then serve over ice in a glass with a salted rim."
            });
            drinks.Add(new Drink
            {
                DrinkId = 8,
                Name = "Martinez",
                ImageName = "Assets/Drinks/Martinez.png",
                Recipe = "1.5 ounces of Old Tom gin, 1.5 ounces of sweet vermouth, a quarter of an ounce of Luxardo maraschino liqueur and 2 dashes of Angostura or orange bitters.",
                Mix = "Stir ingredients in a mixing glass with ice. Strain into chilled martini glass or cocktail glass."
            });
            drinks.Add(new Drink
            {
                DrinkId = 9,
                Name = "Martini",
                ImageName = "Assets/Drinks/Martini.png",
                Recipe = "3 ounces of gin or vodka, half an ounce of dry vermouth and lemon peel or an olive.",
                Mix = "Stir ingredients in a mixing glass with ice. Strain into a chilled martini glass. Squeeze oil from the lemon peel into the glass or garnish with an olive."
            });
            drinks.Add(new Drink
            {
                DrinkId = 10,
                Name = "Mimosa",
                ImageName = "Assets/Drinks/Mimosa.png",
                Recipe = "2.5 ounces of champagne and 2.5 ounces of orange juice.",
                Mix = "Combine equal parts of the ingredients in a champagne flute."
            });
            drinks.Add(new Drink
            {
                DrinkId = 11,
                Name = "Mint Jule",
                ImageName = "Assets/Drinks/Mint Julep.png",
                Recipe = "2 ounces of bourbon, 8 to 10 mint leaves and a quarter of an ounce of simple syrup.",
                Mix = "Mix-up the mint leaves and simple syrup in a cup. Add bourbon and fill with crushed ice. Stir until the cup is frosted. Fill with more crushed ice. Serve with a straw and a mint sprig garnish."
            });
            drinks.Add(new Drink
            {
                DrinkId = 12,
                Name = "Mojito",
                ImageName = "Assets/Drinks/Mojito.png",
                Recipe = "3 mint leaves, 2 ounces of white rum, three quarters of an ounce of lime juice and half an ounce of simple syrup.",
                Mix = "Mix-up mint into a shaker tin, then add ice and all other ingredients. Shake to chill and strain into a highball glass with ice. Top with club soda if desired and garnish with mint."
            });
            drinks.Add(new Drink
            {
                DrinkId = 13,
                Name = "Moscow Mule",
                ImageName = "Assets/Drinks/Moscow Mule.png",
                Recipe = "2 ounces of vodka, 4 to 6 ounces of ginger beer and 5 ounces of lime juice.",
                Mix = "Squeeze lime juice into a mug, add two or three ice cubes, pour in the vodka, and fill with cold ginger beer. Stir and serve."
            });
            drinks.Add(new Drink
            {
                DrinkId = 14,
                Name = "Negroni",
                ImageName = "Assets/Drinks/Negroni.png",
                Recipe = "1 ounce of gin, 1 ounce of Campari and 1 ounce of sweet vermouth.",
                Mix = "Stir ingredients with ice."
            });
            drinks.Add(new Drink
            {
                DrinkId = 15,
                Name = "Old Fashioned",
                ImageName = "Assets/Drinks/Old Fashioned.png",
                Recipe = "2 ounces of bourbon or rye whiskey, 2 dashes of Angostura bitters, 1 sugar cube or 1 tablespoon sugar and an orange twist garnish.",
                Mix = "Put sugar in glass. Cover it with dashes of bitters. Add whiskey and stir until the sugar dissolves. Add ice, stir again, and serve."
            });
            drinks.Add(new Drink
            {
                DrinkId = 16,
                Name = "Paloma",
                ImageName = "Assets/Drinks/Paloma.png",
                Recipe = "2 ounces of tequila, half an ounce of lime juice and grapefruit soda to top.",
                Mix = "Add tequila and lime to a salt-rimmed glass filled with ice. Top with grapefruit soda."
            });
            drinks.Add(new Drink
            {
                DrinkId = 17,
                Name = "Pimms Cup",
                ImageName = "Assets/Drinks/Pimms Cup.png",
                Recipe = "1.75 ounces of  Pimm's No.1, 5 ounces of lemonade, mint, orange, strawberries and cucumber to garnish.",
                Mix = "Pile all the ingredients in a tall glass, mix, and sip."
            });
            drinks.Add(new Drink
            {
                DrinkId = 18,
                Name = "Pina Colada",
                ImageName = "Assets/Drinks/Pina Colada.png",
                Recipe = "3 ounces of white rum, 1.5 ounces of coconut cream, 3.5 ounces of pineapple juice, 10 ounces of crushed ice and 1 slice of pineapple.",
                Mix = "Place the crushed ice into a blender and whizz it for 15 seconds. Now add the coconut cream, rum and the pineapple juice." +
                      "Blend it on medium until you get a smooth, creamy mixture. Pour it into a tall wine glass and garnish the side of the glass with a slice of pineapple."
            });
            drinks.Add(new Drink
            {
                DrinkId = 19,
                Name = "Sazerac",
                ImageName = "Assets/Drinks/Sazerac.png",
                Recipe = "2 ounces of rye whiskey, half an ounce of simple syrup, 2 dashes of Peychaud's bitters and Absinthe.",
                Mix = "Rinse a chilled glass with absinthe and discard the absinthe. Stir the other ingredients in a mixing glass, strain into the chilled glass, and garnish."
            });
            drinks.Add(new Drink
            {
                DrinkId = 20,
                Name = "Sidecar",
                ImageName = "Assets/Drinks/Sidecar.png",
                Recipe = "2 ounces of VS or VSOP Cognac, 1 ounce of Cointreau, three quarters of an ounce of lemon juice.",
                Mix = "Shake ingredients with ice. Strain into a rocks glass or a cocktail class with a sugar-coated rim."
            });
            drinks.Add(new Drink
            {
                DrinkId = 21,
                Name = "Singapore Sling",
                ImageName = "Assets/Drinks/Singapore Sling.png",
                Recipe = "1.5 ounces of Ford’s Gin, a quarter of an ounce of Cherry Herring, a quarter of an ounce of Combier, a quarter of an ounce of Benedictine, 2 ounces  of pineapple juice and a quarter of an ounce of grenadine.",
                Mix = "Add all the ingredients into a shaker over ice. Shake and strain into tiki glass with fresh pebble ice. Garnish with orange peel and macerated cherry."
            });
            drinks.Add(new Drink
            {
                DrinkId = 22,
                Name = "Surfer Girl",
                ImageName = "Assets/Drinks/Surfer Girl.png",
                Recipe = "1.5 ounces of Four Pillars Rare Dry Gin, half an ounce of lime juice, half an ounce of honey, 1 ounce of watermelon juice and 5 to 6 basil leaves.",
                Mix = "Combine all ingredients in a shaker over ice. Shake. Strain into a coupe glass and garnish with basil."
            });
            drinks.Add(new Drink
            {
                DrinkId = 23,
                Name = "Tap Water",
                ImageName = "Assets/Drinks/Empty Glass.png",
                Recipe = "Open the Tap",
                Mix = "Just drink it!"
            });

            return drinks;

        }
    }
}
