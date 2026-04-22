# Poker Decision Intelligence System

A poker-based game intelligence prototype built using Unity + Pure C# architecture to simulate player decision modeling, behavioral analytics, fairness monitoring, and matchmaking systems.

---

## Problem Statement

Competitive gaming platforms often struggle with:

- Detecting suspicious gameplay behavior
- Understanding player decision patterns
- Ensuring fair matchmaking
- Preventing bot-like gameplay behavior

This project explores how decision intelligence systems can improve fairness and integrity in competitive poker environments.

---

# System Architecture

## Core Poker Engine
- Deck generation
- Card distribution
- Round lifecycle management
- Community card generation

---

## Decision Intelligence Layer
- Hand strength evaluation
- Dynamic player decision engine
- Action logging

Tracks actions like:
- Fold
- Call
- Raise

Example:

```json
{
  "playerId": "P1",
  "action": "Raise",
  "handStrength": 0.8,
  "stage": "Flop"
}
```

---

## Player Behavior Analytics
Tracks:

- Aggression score
- Fold rate
- Play style classification

Example:

- Aggressive
- Balanced
- Passive

---

## Fairness Engine
Detects suspicious players by analyzing:

- Excessive aggressive behavior
- Unnaturally consistent decisions
- Risk score generation

Example:

Player P2:
- Aggression Score: 0.8
- Risk Score: 0.5
- Flagged as Suspicious

---

## Upcoming
- Matchmaking Engine
- Better hand evaluator
- Community card impact analysis
- UI visualization dashboard

---

# Tech Stack

- Unity
- Pure C#
- OOP
- Modular Architecture

---

# Why This Project

I wanted to explore how modern competitive gaming systems can move beyond gameplay mechanics and use player intelligence systems to improve fairness, integrity, and matchmaking.

This project aligns closely with real-world competitive gaming challenges.
