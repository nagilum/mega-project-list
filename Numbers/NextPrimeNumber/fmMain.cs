using System;
using System.Windows.Forms;

namespace NextPrimeNumber {
  public partial class fmMain : Form {
    public fmMain() {
      InitializeComponent();
    }

    bool abort = false;

    private void btStart_Click(object sender, EventArgs e) {
      this.abort = false;
      this.modeControls(false);
      this.findPrimes();
      this.modeControls(true);
    }

    private void btStop_Click(object sender, EventArgs e) {
      this.abort = true;
    }

    private void modeControls(bool mode) {
      this.nmNumberToStartWith.Enabled = mode;
      this.btStart.Enabled = mode;
      this.btStop.Enabled = !mode;
    }

    private void findPrimes() {
      ulong number = (ulong) this.nmNumberToStartWith.Value;

      while (true) {
        if (this.abort)
          break;

        this.lbCurrentNumber.Text = number.ToString();

        Application.DoEvents();

        if (this.isPrime(number))
          this.tbFoundPrimes.Text += number.ToString() + ", ";

        number++;
      }

      this.nmNumberToStartWith.Value = (decimal) (number - 1);
    }

    private bool isPrime(ulong number) {
      if (number <= 1)
        return false;

      for (ulong i = 2; i * i <= number; i++)
        if (number % i == 0)
          return false;

      return true;
    }
  }
}
