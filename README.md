# Optimization Problem Solvers
This repository contains implementations of three classical optimization problems: Traveling Salesman Problem (TSP), Map Coloring Problem, and Knapsack Problem. Each problem is solved using different algorithms and programming languages.
## TSP - Traveling Salesman Problem (Python)
- Description: This Python implementation solves the Traveling Salesman Problem (TSP) using the Nearest Neighbor heuristic. The objective is to find the shortest possible route that visits each node (city) exactly once and returns to the origin node.
- Algorithm: Nearest Neighbor Heuristic
  - The algorithm starts at a chosen node, and at each step, visits the nearest unvisited node until all nodes are visited, then returns to the starting node.
  - It is a greedy algorithm, which doesn't guarantee the optimal solution but provides a good approximation in reasonable time
- Features:
   - Reads node coordinates from a CSV file.
   - Plots the nodes and the shortest path on a graph using Matplotlib.
   - Calculates the total travel cost based on Euclidean distances between nodes.
   - Measures the execution time of the nearest neighbor algorithm
- Usage:
  1. Find CSV file with node cordinates in the following format:
```python
X Y
10 20
30 40
50 60
```
  2. Install necessary Python libraries:
```python
pip install matplotlib numpy pandas
```
  3. Run the TSP solution by calling the nearest_neighbor() function, specifying the starting node.
- Code Flow:
1. The read_coordinates_from_csv() function reads the node coordinates from a CSV file.
2. The plot_coordinates_with_labels() function plots the nodes and, optionally, the resulting path on a 2D plane.
3. The nearest_neighbor() function executes the TSP algorithm and returns the optimal path, total travel cost, and the execution time.
