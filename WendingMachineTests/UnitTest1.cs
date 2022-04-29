
using VendingMachine;
using Xunit;


namespace WendingMachineTests
{
   


    
        public class VendingMachineShould
        {



            [Fact]
            public void MoneyInsert()
            {
                //Arrange
                VMachine sut = new VMachine();
                //List<VendingItems> _vendingItems = new List<VendingItems>();
                int amount = 100;
                //Act
                var result = sut.UserInsertMoney(amount);
                //Assert
                Assert.True(result);



            }
            [Fact]
            public void MoneyReturn()
            {
                //Arrange
                VMachine sut = new VMachine();
                int valuta = 50;



                //Act
                int antal = sut.TotalAmountInMachine(valuta);
                //Assert
                Assert.Equal(valuta, antal);
            }


        [Fact]

        public void ArrayTest()
        {
            var sut = new VMachine();   

            //Arrange

            //Act

            //Assert

        }

        }
    }

