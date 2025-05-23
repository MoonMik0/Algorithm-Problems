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
3. The nearest_neighbor() function executes the TSP algorithm and returns the optimal path, total travel cost, graphical output, and the execution time.
----
## Map Coloring Problem (Python):
- Description: This Python implementation solves the Map Coloring Problem using Constraint Satisfaction Problem (CSP) techniques. The objective is to color the nodes of a graph (regions on a map) such that no two adjacent nodes (regions) have the same color, while using the minimum number of colors.
- Algorithm: Constraint Satisfaction Problem (CSP) with Backtracking
  -The algorithm uses CSP to ensure that adjacent nodes (connected by an edge) receive different colors.
  - It assigns colors to nodes by satisfying the constraint that neighboring nodes cannot have the same color.
  - The problem is solved for multiple datasets of different sizes (graphs with 20, 50, 70, 500, and 1000 nodes).
- Features:
  - Reads graph data from text files where each line specifies an edge between two nodes.
  - Implements CSP to find a solution where adjacent nodes have different colors.
  - Plots the graph using NetworkX and colors the nodes based on the solution.
  - Calculates the execution time of the algorithm for each dataset.
- Usage:
  1. Ensure you have the required Python libraries:
  ```python
  pip install matplotlib networkx python-constraint
  ```
  2. Place your graph data files in the ./data/ directory. The data files should follow this format:
  ```python
  20 45  # Number of nodes and edges
  1 2    # Edge between node 1 and node 2
  2 3    # Edge between node 2 and node 3
  ```
  3. Run the map coloring solution
- Code Flow:
  1. Graph Data Input: Graphs are loaded from .txt files that define the nodes and their connections (edges).
  2. Constraint Satisfaction Problem: A CSP model is built where each node is assigned a color, and the algorithm ensures no adjacent nodes share the same color.
  3. Graph Plotting: The resulting colored graph is visualized using NetworkX, where nodes are displayed with their assigned colors.
  4. Execution Time and Solution: For each dataset, the algorithm prints the number of colors used, graphical output and the execution time.
  <img src="https://github.com/user-attachments/assets/dcf27b75-2048-4968-b00d-775d92d7476f" width=400>
  <img src="https://github.com/user-attachments/assets/f30e2f4a-0591-475e-8ec6-429ee670809e" width=400>
  <img src="https://github.com/user-attachments/assets/457412be-b617-4e6d-aa2f-b21d46a6e0b2" width=400>
  <img src="https://github.com/user-attachments/assets/a51efbf7-eb76-4860-865b-3b185c56e24f" width=400>
  <img src="https://github.com/user-attachments/assets/fd781eaf-3fd6-40eb-88de-46f32cab0fae" width=400>
  <img src="https://github.com/user-attachments/assets/e9ded3d2-75ff-46e3-be76-011331e9435c" width=400>
----
## Knapsack Problem (C#)
- Description: This C# implementation solves the 0/1 Knapsack Problem using Dynamic Programming. The goal is to select a subset of items with given values and weights such that the total weight does not exceed the knapsack's capacity, while maximizing the total value.
- Algorithm: Dynamic Programming
  - The algorithm uses a dynamic programming table to keep track of the maximum value obtainable for each capacity up to the given limit.
  - The items are either included or excluded from the solution based on whether they improve the maximum value for a given capacity.
  - Once the table is filled, the selected items are traced back from the table.
- Features:
  - Reads item values and weights from a dataset file and the knapsack's capacity.
  - Implements dynamic programming to find the optimal subset of items that maximizes the total value while respecting the weight constraint.
  - Traces back the items included in the optimal solution.
  - Calculates the execution time of the algorithm.
- Usage:
  1. Place your dataset files in the ./data/ directory. The dataset should be in the following format:
  ```python
  11 15 #first number of elements in dataset second weight of knapsack
  1 7 # first element of data set
  5 4
  ```
  2. Compile and run the C# program using the following commands 
- Code Flow:
   1. File Input: The program reads the dataset from a file that specifies the capacity of the knapsack, the number of items, and their respective values and weights.
   2. Dynamic Programming Solution: It solves the knapsack problem using a dynamic programming approach to determine the maximum value that can be obtained and which items should be included.
   3. Result Display: The program outputs the knapsack's capacity, the maximum value that can be carried, the items selected (represented by 1 or 0), and the time taken to compute the solution.
- Example Output:
  ```python
  Capacity: 1000
  Maximum Value: 1234
  Selected Items: 1, 0, 1, 0, 1
  Execution Time: 0.015 seconds
  ```
----
# License
This project is licensed under the MIT License - see the LICENSE file for details.
----
This project devoloped by Özlem ELMALI
