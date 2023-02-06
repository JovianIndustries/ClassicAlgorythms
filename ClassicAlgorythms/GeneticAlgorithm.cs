using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassicAlgorithms {
	class GeneticAlgorithm {
		static void Test(string[] args) {
			// Set the target string that the algorithm is trying to evolve towards.
			string target = "Hello, world!";

			// Set the population size and the mutation rate.
			int populationSize = 100;
			double mutationRate = 0.01;

			// Create an initial population of random strings.
			string[] population = GenerateRandomPopulation(populationSize, target.Length);

			// Evolve the population until a string in the population matches the target string.
			int generation = 0;
			while (!population.Contains(target)) {
				// Calculate the fitness of each string in the population.
				int[] fitness = CalculateFitness(population, target);

				// Select the fittest strings from the population to be the parents for the next generation.
				string[] parents = SelectParents(population, fitness, target.Length);

				// Generate the next generation of strings by breeding the parents.
				string[] children = Breed(parents, target.Length);

				// Mutate the children with a small probability.
				Mutate(children, mutationRate);

				// Replace the current population with the new generation of strings.
				population = children;

				// Print the generation number and the fittest string in the population.
				Console.WriteLine($"Generation: {generation}, Fittest: {population[0]}");

				generation++;
			}

			Console.WriteLine($"Solution found in generation {generation}: {target}");
		}

		// Generates a population of random strings.
		static string[] GenerateRandomPopulation(int size, int length) {
			string[] population = new string[size];

			for (int i = 0; i < size; i++) {
				population[i] = GenerateRandomString(length);
			}

			return population;
		}

		// Generates a random string of a given length.
		static string GenerateRandomString(int length) {
			Random random = new Random();
			string s = "";

			for (int i = 0; i < length; i++) {
				s += (char)random.Next(32, 126);
			}

			return s;
		}

		// Calculates the fitness of each string in the population.
		static int[] CalculateFitness(string[] population, string target) {
			int[] fitness = new int[population.Length];

			for (int i = 0; i < population.Length; i++) {
				fitness[i] = CalculateStringFitness(population[i], target);
			}

			return fitness;
		}

		// Calculates the fitness of a single string.
		static int CalculateStringFitness(string s, string target) {
			int fitness = 0;

			for (int i = 0; i < s.Length; i++) {
				if (s[i] == target[i]) {
					fitness++;
				}
			}

			return fitness;
		}

		// Selects the fittest strings from the population to be the parents for the next generation.
		static string[] SelectParents(string[] population, int[] fitness, int length) {
			// Sort the population by fitness in descending order.
			Array.Sort(fitness, population, Comparer<int>.Create((x, y) => y.CompareTo(x)));

			// Select the fittest half of the population as the parents.
			string[] parents = new string[length];
			Array.Copy(population, parents, length);

			return parents;
		}

		// Generates the next generation of strings by breeding the parents.
		static string[] Breed(string[] parents, int length) {
			string[] children = new string[parents.Length];

			for (int i = 0; i < parents.Length; i += 2) {
				// Select a crossover point at random.
				var random = new Random();
				int crossover = random.Next(1, length - 1);

				// Breed the parents to produce two children.
				string child1 = parents[i].Substring(0, crossover) + parents[i + 1].Substring(crossover);
				string child2 = parents[i + 1].Substring(0, crossover) + parents[i].Substring(crossover);

				children[i] = child1;
				children[i + 1] = child2;
			}

			return children;
		}

		// Mutates the children with a small probability.
		static void Mutate(string[] children, double rate) {
			Random random = new Random();

			for (int i = 0; i < children.Length; i++) {
				if (random.NextDouble() < rate) {
					// Select a random character in the string to mutate.
					int index = random.Next(0, children[i].Length - 1);

					// Mutate the character by replacing it with a random character.
					char[] chars = children[i].ToCharArray();
					chars[index] = (char)random.Next(32, 126);
					children[i] = new string(chars);
				}
			}
		}
	}
}