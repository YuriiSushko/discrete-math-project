# Topological Sorting Algorithm

This repository contains a C# implementation of a topological sorting algorithm. Topological sorting is a linear ordering of vertices in a directed acyclic graph (DAG) such that for every directed edge from vertex u to vertex v, u comes before v in the ordering.

## Overview

The implementation includes two approaches to perform topological sorting:
- Using adjacency matrices
- Using adjacency lists

Both methods are compared in terms of their performance using a set of tests.

## Files

- **Program.cs**: Contains the main program that executes the tests and measures the performance of the two sorting methods.
- **TopologyDFS.cs**: Defines a class responsible for generating the adjacency matrix and adjacency lists.
- **Vertex.cs**: Defines the Vertex class representing vertices in the graph.
- **Printers.cs**: Contains utility methods for printing the adjacency matrix, adjacency lists, and topological sorting results.

## Usage

To use this implementation, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or any C# compatible IDE.
3. Build the solution.
4. Run the program.
5. If you want to see result of algorithms:
  - Set less numVertices(20 recomended)
  - Uncoment block of code which is comented
  - Run the application

## Performance Evaluation

The performance of the two sorting methods is evaluated based on the execution time of sorting a randomly generated graph with a specified number of vertices and density. The program measures the time taken for both adjacency matrices and adjacency lists methods and calculates the average time over multiple tests. For test results click [here](https://www.notion.so/Discrete-mathematics-project-0ad38f64901e4edc9a3a2ef7bc7aa6c3?pvs=4).

## Parameters

- `numVertices`: Number of vertices in the graph.
- `density`: Density of edges in the graph, ranging from 0 to 1.
- `numOfTests`: Number of tests to perform to evaluate the performance.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributors

- [Sushko Yurii](https://github.com/YuriiSushko) - [created both algorith and tested]
- [Daria Korotych](https://github.com/Daria-Korotych) - [created random matrix generator and described the project]
