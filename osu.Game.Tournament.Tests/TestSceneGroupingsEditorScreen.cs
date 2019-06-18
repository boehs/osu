// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Tournament.Screens.Editors;

namespace osu.Game.Tournament.Tests
{
    public class TestSceneGroupingsEditorScreen : LadderTestScene
    {
        public TestSceneGroupingsEditorScreen()
        {
            Add(new RoundEditorScreen());
        }
    }
}
