# Poker Decision Intelligence System

A poker-based game intelligence prototype built using **Unity + Pure C# architecture** to simulate player decision modeling, behavioral analytics, fairness monitoring, and matchmaking systems.

---

## Why This Project?

Modern competitive gaming platforms face challenges such as:

- Detecting suspicious gameplay behavior
- Identifying bot-like decision patterns
- Understanding player decision quality
- Ensuring fair matchmaking
- Maintaining platform integrity

This project explores how player intelligence systems can improve fairness, integrity, and behavioral understanding in competitive poker ecosystems.

---

# Current System Architecture

## Core Poker Engine
Built using pure C# logic:

- Deck generation
- Card distribution
- Player hand management
- Community card generation
- Round lifecycle management

### Example Output

```text
P1: Ace of Spades, King of Hearts
P2: Seven of Clubs, Queen of Diamonds

Community:
Ten of Hearts, Jack of Clubs, Two of Diamonds
```

---

## Decision Intelligence Layer

Players make dynamic decisions based on hand strength.

### Supported Actions
- Fold
- Call
- Raise

### Decision Logic

```text
Strong Hand → Raise
Medium Hand → Call
Weak Hand → Fold
```

### Sample Decision Log

```json
{
  "playerId": "P1",
  "action": "Raise",
  "handStrength": 0.8,
  "stage": "Flop",
  "potSize": 100
}
```

---

# Player Behavior Analytics

Tracks player behavior across multiple rounds.

### Metrics
- Aggression Score
- Fold Rate
- Play Style Classification

### Player Types
- Aggressive
- Balanced
- Passive

### Sample Output

```text
Player P1:
Aggression → 0.4
Fold Rate → 0.2
Style → Balanced

Player P2:
Aggression → 0.8
Fold Rate → 0.2
Style → Aggressive
```

---

# Fairness Engine

Detects suspicious player behavior patterns.

### Current Detection Signals
- Excessive aggressive behavior
- High decision consistency
- Risk score generation

### Sample Output

```text
Player P1:
Risk Score → 0
Suspicious → False

Player P2:
Risk Score → 0.5
Suspicious → True
```

---

# Architecture Flow

```text
Poker Engine
   ↓
Decision Engine
   ↓
Decision Logger
   ↓
Player Profiling
   ↓
Fairness Engine
   ↓
Matchmaking Engine (Upcoming)
```

---

# Tech Stack

- Unity
- Pure C#
- Object-Oriented Design
- Modular Architecture

---

# Upcoming Improvements

- Matchmaking Engine
- Better hand evaluation logic
- Community card impact analysis
- Decision quality scoring
- UI dashboard visualization

---

# Why This Matters

This project demonstrates how gameplay systems can evolve beyond core gameplay mechanics into:

- Player intelligence systems
- Behavioral analytics systems
- Fairness systems
- Competitive gaming integrity systems

Built to explore challenges similar to modern competitive gaming platforms.
