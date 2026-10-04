**Check** | **Finding / Fix**

- One-handed reach: every control reachable with the thumb. | Yes, every control is reachable with the thumb.
- Smallest button at least 48 dp including padding (measure against a 48 dp reference square in the Device Simulator). | Yes every button is at least 48dp.
- Android **Settings > Display > Display size and text** at maximum: HUD still inside the safe area. | Yes HUD remnains within the safe area.
- **Developer options > Simulate colour space > Monochromacy**: every game state still readable. | Yes every game state is readable
- Volume at zero: the game still tells you what happened. | Yes
- Text contrast 4.5:1 (use any online contrast checker with your colours). | Text Contrast is 11.93:1
- Motion or screen shake behind a toggle (add the toggle now even if it only stores a value). | The game does not contain a motion/ screen shake toggle. 
- No timed tap without an alternative or a slower mode. | Need to implement aternative.
- Haptics off: nothing is lost. | Nothing is lost if haptics are disabled.
- 60 seconds of silent observation: write down the first thing your neighbour got wrong. 