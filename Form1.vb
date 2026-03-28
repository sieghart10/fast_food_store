Public Class frmMainMenu

    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct.SelectedIndexChanged
        If cboProduct.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim strProduct As String = cboProduct.SelectedItem.ToString()
            Dim productIndex As Integer = cboProduct.Items.IndexOf(strProduct)

            If productIndex = 0 Then
                'lbTotal.Text = strProduct.ToString()
                pboProduct.BackgroundImage = My.Resources.logo

            ElseIf productIndex = 1 Then
                pboProduct.BackgroundImage = My.Resources.hamburger

            ElseIf productIndex = 2 Then
                pboProduct.BackgroundImage = My.Resources.Fries

            ElseIf productIndex = 3 Then
                pboProduct.BackgroundImage = My.Resources.Footlong

            ElseIf productIndex = 4 Then
                pboProduct.BackgroundImage = My.Resources.Sandwich

            ElseIf productIndex = 5 Then
                pboProduct.BackgroundImage = My.Resources.Softdrink
            End If
        End If

    End Sub

    Private total_price As Double = 0
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboProduct.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not Single.TryParse(txtQty.Text, Nothing) Then
            MessageBox.Show("Please input a valid numeric quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim strProduct As String = cboProduct.SelectedItem.ToString()
            Dim productIndex As Integer = cboProduct.Items.IndexOf(strProduct)
            Dim productQty As Integer

            If Integer.TryParse(txtQty.Text, productQty) Then
                If productQty > 99 Then
                    MessageBox.Show("Maximum quantity is only 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    productQty = 99
                    txtQty.Text = productQty.ToString()
                ElseIf productIndex = 0 Then
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf productQty = 0 Then
                    MessageBox.Show("Please select a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim productPrice As Double
                    If productIndex = 1 Then
                        productPrice = 50.0

                    ElseIf productIndex = 2 Then
                        productPrice = 30.0

                    ElseIf productIndex = 3 Then
                        productPrice = 40.0

                    ElseIf productIndex = 4 Then
                        productPrice = 45.0

                    ElseIf productIndex = 5 Then
                        productPrice = 25.0

                    End If

                    Dim productTotal As Double
                    Dim index As Integer = lstProduct.Items.IndexOf(strProduct)

                    If index >= 0 Then
                        ' If it's in the list, update the quantity and price
                        Dim existingQty As Integer

                        If Integer.TryParse(lstQty.Items(index).ToString(), existingQty) Then
                            existingQty += productQty
                            If existingQty < 100 Then
                                lstQty.Items(index) = existingQty
                                productTotal = existingQty * productPrice
                                lstTotal.Items(index) = productTotal
                                total_price += productQty * productPrice
                            Else
                                MessageBox.Show("Product quantity must not exceed 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        Else
                                ' Handle the conversion failure gracefully
                                MessageBox.Show("Product reached its maximum quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        lstPrice.Items(index) = productPrice
                    Else
                        ' If not in the list, add a new entry
                        lstProduct.Items.Add(strProduct)
                        lstPrice.Items.Add(productPrice)
                        lstQty.Items.Add(productQty)
                        productTotal = productQty * productPrice
                        lstTotal.Items.Add(productTotal)
                        total_price += productTotal
                    End If

                    lbTotal.Text = "₱" + total_price.ToString("0.00")
                End If
            Else
                MessageBox.Show("Please select a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim productQty As Integer

        If Integer.TryParse(txtQty.Text, productQty) Then
            ' Perform the subtraction
            If productQty > 0 Then
                productQty -= 1
                'Else
                'MessageBox.Show("Quantity cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Return
            End If

            ' Update the TextBox with the new value
            txtQty.Text = productQty.ToString()
        Else
            MessageBox.Show("Please enter a valid numeric quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim productQty As Integer

        If Integer.TryParse(txtQty.Text, productQty) Then
            If productQty < 99 Then
                productQty += 1

            Else
                MessageBox.Show("Maximum quantity is only 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                productQty = 99
                txtQty.Text = productQty.ToString()
                Return
            End If

        Else
            productQty = 1
            'MessageBox.Show("Please enter a valid numeric quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtQty.Text = productQty.ToString()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstProduct.Items.Clear()
        lstPrice.Items.Clear()
        lstQty.Items.Clear()
        lstTotal.Items.Clear()
        lbTotal.Text = ""
    End Sub
End Class