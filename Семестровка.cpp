// Ford-Fulkerson algorith in C++

#include <limits.h>
#include <string.h>
#include <fstream>
#include <iostream>
#include <queue>
using namespace std;

#define V 250

bool bfs(int rGraph[V][V], int s, int t, int parent[]) {
    bool visited[V];
    memset(visited, 0, sizeof(visited));

    queue<int> q;
    q.push(s);
    visited[s] = true;
    parent[s] = -1;

    while (!q.empty()) {
        int u = q.front();
        q.pop();

        for (int v = 0; v < V; v++) {
            if (visited[v] == false && rGraph[u][v] > 0) {
                q.push(v);
                parent[v] = u;
                visited[v] = true;
            }
        }
    }

    return (visited[t] == true);
}

int fordFulkerson(int graph[V][V], int s, int t) {
    int u, v;

    int rGraph[V][V];
    for (u = 0; u < V; u++)
        for (v = 0; v < V; v++)
            rGraph[u][v] = graph[u][v];

    int parent[V];
    int max_flow = 0;
    int iteration = 0;

    while (bfs(rGraph, s, t, parent)) {
        int path_flow = INT_MAX;
        for (v = t; v != s; v = parent[v]) {
            u = parent[v];
            path_flow = min(path_flow, rGraph[u][v]);
        }

        for (v = t; v != s; v = parent[v]) {
            u = parent[v];
            rGraph[u][v] -= path_flow;
            rGraph[v][u] += path_flow;
        }

        max_flow += path_flow;
        iteration++;
    }
    cout << iteration << endl;
    return max_flow;
}

int main() {
    int graph[V][V];
    ifstream reader;
    string path = "C:\\Users\\User\\OneDrive\\Рабочий стол\\семестровка\\250.txt";
    reader.open(path, ios_base::in);

    for (int i = 0; i < V; ++i)
        for (int j = 0; j < V; ++j)
            reader >> graph[i][j];

    cout << "Max Flow: " << fordFulkerson(graph, 0, 5)<< endl;
}