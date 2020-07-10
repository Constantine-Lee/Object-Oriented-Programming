using System;
using SwinGameSDK;

namespace MyGame
{

    public class ZYcharacterSelection: View
    { 
    private string _image;
    private Button _maleButton;
    private Button _femaleButton;
    private Sprite _menu;

    public ZYcharacterSelection(ViewManager viewManager) : base(viewManager)
    {
        //background Image
        _image = "characterSelectionBackground.jpg";
        SwinGame.LoadBitmapNamed(_image, _image);
        _menu = SwinGame.CreateSprite(SwinGame.BitmapNamed(_image));
        //

        //Male Button
        _maleButton = new Button("grey_button06.png");
        _maleButton.SetWidth(191);
        _maleButton.SetHeight(49);
        _maleButton.SetText(" Male ", 25);
            //

            _femaleButton = new Button("grey_button06.png");
            _femaleButton.SetWidth(191);
            _femaleButton.SetHeight(49);
            _femaleButton.SetText(" Female ", 25);

    }

    public override void Draw()
    {
        SwinGame.DrawSprite(_menu);
            SwinGame.DrawText("Choose Your Gender", Color.Black, "Arial", 35, 90, 150);
            _maleButton.Draw();
            _femaleButton.Draw();
    }

    public override void Update()
    {
    }

    public override void ProcessEvent()
    {
        if (SwinGame.MouseClicked(MouseButton.LeftButton))
        {
            if (_maleButton.IsAt(SwinGame.MousePosition()))
            {
                    Player.PlayerImage = "Player";
                _viewManager.View = _viewManager.NewGame();
            }
            if (_femaleButton.IsAt(SwinGame.MousePosition()))
            {
                    Player.PlayerImage = "Player2";
                _viewManager.View = _viewManager.NewGame();
            }
         }
    }

    //x = 0
    public void SetX(int x)
    {
        _maleButton.SetX(x + 40);
        _maleButton.SetTextPositionX(x + 95);
            _femaleButton.SetX(x + 270);
            _femaleButton.SetTextPositionX(x + 320);
    }

    //y = 0
    public void SetY(int y)
    {
        _maleButton.SetY(y + 220);
        _maleButton.SetTextPositionY(y + 230);

            _femaleButton.SetY(y + 220);
            _femaleButton.SetTextPositionY(y + 230);
    }
}
}