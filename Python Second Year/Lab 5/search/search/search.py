# search.py
# ---------
# Licensing Information:  You are free to use or extend these projects for
# educational purposes provided that (1) you do not distribute or publish
# solutions, (2) you retain this notice, and (3) you provide clear
# attribution to UC Berkeley, including a link to http://ai.berkeley.edu.
# 
# Attribution Information: The Pacman AI projects were developed at UC Berkeley.
# The core projects and autograders were primarily created by John DeNero
# (denero@cs.berkeley.edu) and Dan Klein (klein@cs.berkeley.edu).
# Student side autograding was added by Brad Miller, Nick Hay, and
# Pieter Abbeel (pabbeel@cs.berkeley.edu).


"""
In search.py, you will implement generic search algorithms which are called by
Pacman agents (in searchAgents.py).
"""

import util

class SearchProblem:
    """
    This class outlines the structure of a search problem, but doesn't implement
    any of the methods (in object-oriented terminology: an abstract class).

    You do not need to change anything in this class, ever.
    """

    def getStartState(self):
        """
        Returns the start state for the search problem.
        """
        util.raiseNotDefined()

    def isGoalState(self, state):
        """
          state: Search state

        Returns True if and only if the state is a valid goal state.
        """
        util.raiseNotDefined()

    def getSuccessors(self, state):
        """
          state: Search state

        For a given state, this should return a list of triples, (successor,
        action, stepCost), where 'successor' is a successor to the current
        state, 'action' is the action required to get there, and 'stepCost' is
        the incremental cost of expanding to that successor.
        """
        util.raiseNotDefined()

    def getCostOfActions(self, actions):
        """
         actions: A list of actions to take

        This method returns the total cost of a particular sequence of actions.
        The sequence must be composed of legal moves.
        """
        util.raiseNotDefined()


def tinyMazeSearch(problem):
    """
    Returns a sequence of moves that solves tinyMaze.  For any other maze, the
    sequence of moves will be incorrect, so only use this for tinyMaze.
    """
    from game import Directions
    s = Directions.SOUTH
    w = Directions.WEST
    return  [s, s, w, s, w, w, s, w]


def depthFirstSearch(problem):                                                              #Question 1
    """
    Search the deepest nodes in the search tree first.

    Your search algorithm needs to return a list of actions that reaches the
    goal. Make sure to implement a graph search algorithm.

    To get started, you might want to try some of these simple commands to
    understand the search problem that is being passed in:

    print("Start:", problem.getStartState())
    print("Is the start a goal?", problem.isGoalState(problem.getStartState()))
    print("Start's successors:", problem.getSuccessors(problem.getStartState()))
    """
    """
    Before start, understand how to get starting state and its output
                  understand how to check if current state is goal state and its output
                  understand how to get successors and its output
                  understand how to push current position and path from Stack in Util
                  understand how to pop the last element in the Stack
                  understand how to get starting state
                  understand how to check if current position is the goal
                  understand how to access elements in successors
    """
    "*** YOUR CODE HERE ***"

    #Using DFS, the pathway will be constructed using Stack's LIFO (Last In First Out) policy located in the util class.
    pathway = util.Stack()

    #Push the current / initial state into the stack, which indicates the initial / start state, as well as the actions and cost. 
    pathway.push((problem.getStartState(), [], 0))

    #Display the initial state position
    print("\nStarting Position: ", problem.getStartState())
  
    while not pathway.isEmpty(): #Will continue exploring each node until the path / stack is empty.  
        node, path, cost = pathway.pop() #Get the current node / state from the path and store them as state (node), action (path), and cost

        if problem.isGoalState(node): #If the Goal State is discovered, it will be returned as a verified explored node.
            print("Steps taken: ", path) #Print out the actions taken along the path to reach the goal.
            print("Goal position: ", node) #Print the goal position / state 
            return path

        #Else, get a list of successor nodes / paths 
        for n, p, c in problem.getSuccessors(node):

            #If the node has not been explored, push the successor(s) into the path / stack.
            if n not in pathway.list and n not in problem._visitedlist:
                pathway.push((n, path + [p], c))

    return False
    
    #util.raiseNotDefined()


def breadthFirstSearch(problem):                                                            #Question 2
    """Search the shallowest nodes in the search tree first."""
    "*** YOUR CODE HERE ***"

    #Display the initial state position
    print("\nStarting Position: ", problem.getStartState())

    #Using BFS, the pathway will be constructed using Queue's FIFO (First In First Out) policy located in the util class.
    pathway = util.Queue()

    #Push the current / initial state into the queue, which indicates the initial / start state, as well as the actions and cost. 
    pathway.push((problem.getStartState(), [], 0))



    #Stores the paths / states that have been explored previously
    exploredPath = set()
  
    while not pathway.isEmpty(): #Will continue exploring each node until the path / stack is empty.
        node, path, cost = pathway.pop() #Get the current node / state from the path and store them as state (node), action (path), and cost
        
        if problem.isGoalState(node): #If the Goal State is discovered, it will be returned as a verified explored node.
            print("Steps taken: ", path) #Print out the actions taken along the path to reach the goal.
            print("Goal position: ", node) #Print the goal position / state 

            return path

        #If the current state is already stored as explored, continue the operation.
        if node in exploredPath:
            continue

        #Submit the current state as an explored node / state. 
        exploredPath.add(node)
        
        #Iterate through successor nodes.
        for n, p, c in problem.getSuccessors(node):

            #If the node has not been explored and is also not found in the explored paths, push the successor(s) into the path / stack.
            if n not in pathway.list and n not in exploredPath:
                pathway.push((n, path + [p], c))

    return False

    #util.raiseNotDefined()

def uniformCostSearch(problem):
    """Search the node of least total cost first."""
    "*** YOUR CODE HERE ***"
    util.raiseNotDefined()

def nullHeuristic(state, problem=None):
    """
    A heuristic function estimates the cost from the current state to the nearest
    goal in the provided SearchProblem.  This heuristic is trivial.
    """
    return 0

def aStarSearch(problem, heuristic=nullHeuristic):
    """Search the node that has the lowest combined cost and heuristic first."""
    "*** YOUR CODE HERE ***"

    #Using A* search, the pathway will be constructed using PriorityQueue's lowest-priority item policy located in the util class.
    pathway = util.PriorityQueue()

    #Stores the paths / states that have been explored previously
    exploredNodes = [] #Holds the (state, cost)

    #Store the current / initial state
    startState = problem.getStartState()

    #Store the current / initial state as well as the actions and cost.
    startNode = (startState, [], 0) #(state, action, cost)

    #Push the current / initial state into the queue
    pathway.push(startNode, 0)

    while not pathway.isEmpty():#Will continue exploring each node until the path / stack is empty.

        #Begin exploring the first node on the pathway using the lowest-combined (cost+heuristic)
        currentState, actions, currentCost = pathway.pop()

        #Store the popped node into the explored list.
        currentNode = (currentState, currentCost)
        exploredNodes.append((currentState, currentCost))

        if problem.isGoalState(currentState):#If the Goal State is discovered, it will be returned as a verified explored node.
            print("Steps taken: ", actions) #Print out the actions taken along the path to reach the goal.
            print("Goal position: ", currentState) #Print the goal position / state 
            return actions

        else:
            #Else, get a list of successor nodes along with the current action and cost
            successors = problem.getSuccessors(currentState)

            #Examine each successor and determine costs.
            for succState, succAction, succCost in successors:
                newAction = actions + [succAction]
                newCost = problem.getCostOfActions(newAction)
                newNode = (succState, newAction, newCost)

                #Checks if the current successor has been explored.
                already_explored = False
                for explored in exploredNodes:
                    #Examine each explored node tuple.
                    exploredState, exploredCost = explored

                    #Verify if successor has already been explored. 
                    if (succState == exploredState) and (newCost >= exploredCost):
                        already_explored = True

                #If the current successor has not been explored, push it onto the pathway and explored list.
                if not already_explored:
                    pathway.push(newNode, newCost + heuristic(succState, problem))
                    exploredNodes.append((succState, newCost))

    return actions
    
    #util.raiseNotDefined()


# Abbreviations
bfs = breadthFirstSearch
dfs = depthFirstSearch
astar = aStarSearch
ucs = uniformCostSearch
