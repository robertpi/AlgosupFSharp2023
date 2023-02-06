namespace FSharpKoans
open FSharpExercises.Core
open NUnit.Framework
open System

module ExercisesDay5And6_11Poker =

    // Pick the best hand(s) from a list of poker hands.

    // See [wikipedia](https://en.wikipedia.org/wiki/List_of_poker_hands) for an
    // overview of poker hands.

    // # Hints

    // - [Designing with types](http://fsharpforfunandprofit.com/series/designing-with-types.html) To come up with a clean and easy to read solution for this make sure to choose the right types to represent the different parts of the problem (think of suits, values, cards, etc)

    let bestHands input = __

    [<Ignore("Not implemented");Test>]
    let ``Poker - Single hand always wins`` () =
        let hands = ["4S 5S 7H 8D JC"]
        let expected = ["4S 5S 7H 8D JC"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Highest card out of all hands wins`` () =
        let hands = ["4D 5S 6S 8D 3C"; "2S 4C 7S 9H 10H"; "3S 4S 5D 6H JH"]
        let expected = ["3S 4S 5D 6H JH"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - A tie has multiple winners`` () =
        let hands = ["4D 5S 6S 8D 3C"; "2S 4C 7S 9H 10H"; "3S 4S 5D 6H JH"; "3H 4H 5C 6C JD"]
        let expected = ["3S 4S 5D 6H JH"; "3H 4H 5C 6C JD"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Multiple hands with the same high cards, tie compares next highest ranked, down to last card`` () =
        let hands = ["3S 5H 6S 8D 7H"; "2S 5D 6D 8C 7S"]
        let expected = ["3S 5H 6S 8D 7H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - One pair beats high card`` () =
        let hands = ["4S 5H 6C 8D KH"; "2S 4H 6S 4D JH"]
        let expected = ["2S 4H 6S 4D JH"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Highest pair wins`` () =
        let hands = ["4S 2H 6S 2D JH"; "2S 4H 6C 4D JD"]
        let expected = ["2S 4H 6C 4D JD"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Two pairs beats one pair`` () =
        let hands = ["2S 8H 6S 8D JH"; "4S 5H 4C 8C 5C"]
        let expected = ["4S 5H 4C 8C 5C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have two pairs, highest ranked pair wins`` () =
        let hands = ["2S 8H 2D 8D 3H"; "4S 5H 4C 8S 5D"]
        let expected = ["2S 8H 2D 8D 3H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have two pairs, with the same highest ranked pair, tie goes to low pair`` () =
        let hands = ["2S QS 2C QD JH"; "JD QH JS 8D QC"]
        let expected = ["JD QH JS 8D QC"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have two identically ranked pairs, tie goes to remaining card (kicker)`` () =
        let hands = ["JD QH JS 8D QC"; "JS QS JC 2D QD"]
        let expected = ["JD QH JS 8D QC"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have two pairs that add to the same value, win goes to highest pair`` () =
        let hands = ["6S 6H 3S 3H AS"; "7H 7S 2H 2S AC"]
        let expected = ["7H 7S 2H 2S AC"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Two pairs first ranked by largest pair`` () =
        let hands = ["5C 2S 5S 4H 4C"; "6S 2S 6H 7C 2C"]
        let expected = ["6S 2S 6H 7C 2C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Three of a kind beats two pair`` () =
        let hands = ["2S 8H 2H 8D JH"; "4S 5H 4C 8S 4H"]
        let expected = ["4S 5H 4C 8S 4H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have three of a kind, tie goes to highest ranked triplet`` () =
        let hands = ["2S 2H 2C 8D JH"; "4S AH AS 8C AD"]
        let expected = ["4S AH AS 8C AD"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - With multiple decks, two players can have same three of a kind, ties go to highest remaining cards`` () =
        let hands = ["4S AH AS 7C AD"; "4S AH AS 8C AD"]
        let expected = ["4S AH AS 8C AD"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - A straight beats three of a kind`` () =
        let hands = ["4S 5H 4C 8D 4H"; "3S 4D 2S 6D 5C"]
        let expected = ["3S 4D 2S 6D 5C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Aces can end a straight (10 J Q K A)`` () =
        let hands = ["4S 5H 4C 8D 4H"; "10D JH QS KD AC"]
        let expected = ["10D JH QS KD AC"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Aces can start a straight (A 2 3 4 5)`` () =
        let hands = ["4S 5H 4C 8D 4H"; "4D AH 3S 2D 5C"]
        let expected = ["4D AH 3S 2D 5C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands with a straight, tie goes to highest ranked card`` () =
        let hands = ["4S 6C 7S 8D 5H"; "5S 7H 8S 9D 6H"]
        let expected = ["5S 7H 8S 9D 6H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Even though an ace is usually high, a 5-high straight is the lowest-scoring straight`` () =
        let hands = ["2H 3C 4D 5D 6H"; "4S AH 3S 2D 5H"]
        let expected = ["2H 3C 4D 5D 6H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Flush beats a straight`` () =
        let hands = ["4C 6H 7D 8D 5H"; "2S 4S 5S 6S 7S"]
        let expected = ["2S 4S 5S 6S 7S"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have a flush, tie goes to high card, down to the last one if necessary`` () =
        let hands = ["4H 7H 8H 9H 6H"; "2S 4S 5S 6S 7S"]
        let expected = ["4H 7H 8H 9H 6H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Full house beats a flush`` () =
        let hands = ["3H 6H 7H 8H 5H"; "4S 5H 4C 5D 4H"]
        let expected = ["4S 5H 4C 5D 4H"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have a full house, tie goes to highest-ranked triplet`` () =
        let hands = ["4H 4S 4D 9S 9D"; "5H 5S 5D 8S 8D"]
        let expected = ["5H 5S 5D 8S 8D"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - With multiple decks, both hands have a full house with the same triplet, tie goes to the pair`` () =
        let hands = ["5H 5S 5D 9S 9D"; "5H 5S 5D 8S 8D"]
        let expected = ["5H 5S 5D 9S 9D"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Four of a kind beats a full house`` () =
        let hands = ["4S 5H 4D 5D 4H"; "3S 3H 2S 3D 3C"]
        let expected = ["3S 3H 2S 3D 3C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have four of a kind, tie goes to high quad`` () =
        let hands = ["2S 2H 2C 8D 2D"; "4S 5H 5S 5D 5C"]
        let expected = ["4S 5H 5S 5D 5C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - With multiple decks, both hands with identical four of a kind, tie determined by kicker`` () =
        let hands = ["3S 3H 2S 3D 3C"; "3S 3H 4S 3D 3C"]
        let expected = ["3S 3H 4S 3D 3C"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Straight flush beats four of a kind`` () =
        let hands = ["4S 5H 5S 5D 5C"; "7S 8S 9S 6S 10S"]
        let expected = ["7S 8S 9S 6S 10S"]
        bestHands hands |> AssertEquality expected

    [<Ignore("Not implemented");Test>]
    let ``Poker - Both hands have straight flush, tie goes to highest-ranked card`` () =
        let hands = ["4H 6H 7H 8H 5H"; "5S 7S 8S 9S 6S"]
        let expected = ["5S 7S 8S 9S 6S"]
        bestHands hands |> AssertEquality expected