unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  Buttons, ComCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    BitBtn3: TBitBtn;
    ed: TEdit;
    ed1: TEdit;
    Label1: TLabel;
    mm: TMemo;
    pb: TProgressBar;
    tb: TTrackBar;
    procedure BitBtn1Click(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure tbChange(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.Label1Click(Sender: TObject);
begin
       mm.Lines.Add('Take are changing');
end;

procedure TForm1.tbChange(Sender: TObject);
begin
  pb.Position:=100-tb.Position;
  ed1.Text(IntToStr(100-tb.Position));
end;

procedure TForm1.BitBtn1Click(Sender: TObject);
begin
  mm.Lines.Add(ed.Text);
end;

end.

