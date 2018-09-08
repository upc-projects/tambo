
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Enzo Lizama
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_LISTAR_VENTAS
AS
BEGIN
	SELECT * FROM Venta
END
GO


CREATE PROCEDURE SP_REGISTRAR_VENTA(
	@TOTAL AS FLOAT
)
AS
BEGIN
	INSERT INTO Venta VALUES(@TOTAL)
END
GO

CREATE PROCEDURE SP_ELIMINAR_VENTA(
	@ID AS INT
)
AS
BEGIN
	DELETE FROM Venta WHERE id = @ID
END
GO
