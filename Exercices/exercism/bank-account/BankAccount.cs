
public class BankAccount
{
    // public decimal  Balance {get; private set;}
    private decimal _balance;
    private bool _isOpen;

    private readonly object _lock = new object();

    public void Open()
    {

        if (_isOpen)
            throw new InvalidOperationException("Account is already open.");
        _isOpen = true;
        _balance = 0m;
    }

    public void Close()
    {
        if(!_isOpen)
            throw new InvalidOperationException("Account is not open.");
        _isOpen = false;
        _balance = 0m; // Reset balance when closing the account

    }

    public decimal Balance
    {
        get
        {
            if (!_isOpen)
                throw new InvalidOperationException("Cannot check balance of a closed or unopened account.");
            return _balance;
        }

    }


    public void Deposit(decimal change)
    {
        lock (_lock)
        {
            if (!_isOpen)
                throw new InvalidOperationException("Cannot deposit into a closed or unopened account.");

            if (change < 0)
                throw new InvalidOperationException("Deposit amount must be non-negative.");

            _balance += change;

        }
    }

    public void Withdraw(decimal change)
    {

        lock (_lock)
        {
            if (!_isOpen)
                throw new InvalidOperationException("Cannot withdraw from a closed or unopened account.");

            if (change < 0)
                throw new InvalidOperationException("Withdrawal amount must be non-negative.");

            if (change > _balance)
                throw new InvalidOperationException("Insufficient funds for withdrawal.");

            _balance -= change;
        
        }


    }
}
