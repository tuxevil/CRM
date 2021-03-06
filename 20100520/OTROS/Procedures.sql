

CREATE PROCEDURE [dbo].[sp_InsertCustomer]
(
@COMPANY INT = 0,
@IBTAXADITIONALCODE varchar(2) = '', 
@IBTAXCODE varchar(2) = '', 
@IBBTAXCODE smallint = 0, 
@NCTAXCODE smallint = 0, 
@ZIPCODE varchar(8) = '', 
@CLAUSE bit = 0, 
@CODE varchar(6) = '', 
@STATECODE varchar(2) = '', 
@TRANSPORTCODE varchar(2) = '', 
@EMPLOYEECODE varchar(2) = '', 
@ZONECODE varchar(2) = '', 
@SALESTERMCODE smallint = 0, 
@CUIT varchar(20) = '', 
@BIRTHDAY varchar(60) = '1800/01/01', 
@CREDIT decimal = 0, 
@ADRESS varchar(55) = '', 
@DELIVERYADRESS varchar(30) = '', 
@MAIL varchar(60) = '', 
@EXPORT bit = 0, 
@REGISTRATIONDATE varchar(60) = '1800/01/01', 
@GROUPCODE varchar(6) = '', 
@IBCALC bit = 0, 
@IBBCALC bit = 0, 
@INTERNALTAXDETAIL bit = 0, 
@IBBINTERNALTAX bit = 0, 
@INTERNALTAXCALC bit = 0, 
@IVADETAIL bit = 0, 
@IVACALC bit = 0, 
@IVAFREE bit = 0, 
@CITY varchar(20) = '', 
@IBNUMBER varchar(20) = '', 
@NAME varchar(60) = '', 
@SALESLISTCODE smallint = 0, 
@HOURS varchar(60) = '', 
@DISCOUNTPERCENT decimal = 0, 
@IVAEXCLUSIONPERCENT decimal = 0, 
@IVAFREEPERCENT decimal = 0, 
@LEGALNAME varchar(60) = '', 
@INTERNALTAXPLUS bit = 0, 
@IVAPLUS bit = 0, 
@PHONE varchar(30) = '', 
@FAX varchar(30) = '', 
@TIPO varchar(1) = '', 
@IDCODE smallint = 0, 
@FECHA_MODI datetime = '1800/01/01', 
@EXP_SALDO bit = 0, 
@CURRENCYCODE BIT = 1, 
@SUCUR_ORI smallint = 0, 
@WEB varchar(60) = '', 
@COD_RUBRO varchar(4) = '', 
@NOTES varchar(max) = ''
)

AS

BEGIN

DECLARE @ID INT

SET @ID = 0

INSERT INTO [dbo].[GVA14]
			(
			ALI_ADI_IB, 
			ALI_FIJ_IB, 
			AL_FIJ_IB3, 
			ALI_NO_CAT, 
			C_POSTAL, 
			CLAUSULA, 
			COD_CLIENT, 
			COD_PROVIN, 
			COD_TRANSP, 
			COD_VENDED, 
			COD_ZONA, 
			COND_VTA, 
			CUIT, 
			CUMPLEANIO, 
			CUPO_CREDI, 
			DIR_COM, 
			DOMICILIO, 
			E_MAIL, 
			EXPORTA, 
			FECHA_ALTA, 
			GRUPO_EMPR, 
			IB_L, 
			IB_L3, 
			II_D, 
			II_IB3, 
			II_L, 
			IVA_D, 
			IVA_L, 
			LIB, 
			LOCALIDAD, 
			N_ING_BRUT, 
			NOM_COM, 
			NRO_LISTA, 
			OBSERVACIO, 
			PORC_DESC, 
			PORC_EXCL, 
			PORC_L, 
			RAZON_SOCI, 
			SOBRE_II, 
			SOBRE_IVA, 
			TELEFONO_1, 
			TELEFONO_2, 
			TIPO, 
			TIPO_DOC, 
			FECHA_MODI, 
			MON_CTE, 
			SUCUR_ORI)
     VALUES
			(
			@IBTAXADITIONALCODE, 
			@IBTAXCODE, 
			@IBBTAXCODE, 
			@NCTAXCODE, 
			@ZIPCODE, 
			@CLAUSE,  
			@CODE, 
			@STATECODE, 
			@TRANSPORTCODE, 
			@EMPLOYEECODE, 
			@ZONECODE, 
			@SALESTERMCODE, 
			@CUIT, 
			CONVERT(DATETIME, @BIRTHDAY, 102), 
			@CREDIT, 
			@ADRESS, 
			@DELIVERYADRESS, 
			@MAIL, 
			@EXPORT, 
			CONVERT(DATETIME, @REGISTRATIONDATE, 102), 
			@GROUPCODE, 
			@IBCALC, 
			@IBBCALC, 
			(CASE WHEN @INTERNALTAXDETAIL = 0 THEN 'N' ELSE 'S' END), 
			@IBBINTERNALTAX, 
			(CASE WHEN @INTERNALTAXCALC = 0 THEN 'N' ELSE 'S' END), 
			(CASE WHEN @IVADETAIL = 0 THEN 'N' ELSE 'S' END), 
			(CASE WHEN @IVACALC = 0 THEN 'N' ELSE 'S' END), 
			(CASE WHEN @IVAFREE = 0 THEN 'N' ELSE 'S' END), 
			@CITY, 
			@IBNUMBER, 
			@NAME, 
			@SALESLISTCODE, 
			@HOURS, 
			@DISCOUNTPERCENT, 
			@IVAEXCLUSIONPERCENT, 
			@IVAFREEPERCENT, 
			@LEGALNAME, 
			(CASE WHEN @INTERNALTAXPLUS = 0 THEN 'N' ELSE 'S' END), 
			(CASE WHEN @IVAPLUS = 0 THEN 'N' ELSE 'S' END), 
			@PHONE, 
			@FAX, 
			@TIPO, 
			@IDCODE, 
			@FECHA_MODI, 
			@CURRENCYCODE, 
			@SUCUR_ORI)

	SET @ID = @@IDENTITY

	IF @ID > 0
	BEGIN
		DELETE FROM GVA111 WHERE COD_CLIENT = @CODE
		INSERT INTO GVA111 (COD_CLIENT, NRO_RENGL, TEXTO)
					VALUES (@CODE, 1, @NOTES)		

		INSERT INTO <ownerdatabase>.dbo.REALCUSTOMERS (ID_COMPANY, COD_CLIENT, WEB)
					VALUES (@COMPANY, @CODE, @WEB)
	END

	RETURN @ID

END







CREATE PROCEDURE [dbo].[sp_UpdateCustomer]
(
@COMPANY INT = 0,
@IBTAXADITIONALCODE varchar(2) = '', 
@IBTAXCODE varchar(2) = '', 
@IBBTAXCODE smallint = 0, 
@NCTAXCODE smallint = 0, 
@ZIPCODE varchar(8) = '', 
@CLAUSE bit = 0, 
@CODE varchar(6) = '', 
@STATECODE varchar(2) = '', 
@TRANSPORTCODE varchar(2) = '', 
@EMPLOYEECODE varchar(2) = '', 
@ZONECODE varchar(2) = '', 
@SALESTERMCODE smallint = 0, 
@CUIT varchar(20) = '', 
@BIRTHDAY varchar(60) = '1800/01/01', 
@CREDIT decimal = 0, 
@ADRESS varchar(55) = '', 
@DELIVERYADRESS varchar(30) = '', 
@MAIL varchar(60) = '', 
@EXPORT bit = 0, 
@REGISTRATIONDATE varchar(60) = '1800/01/01', 
@GROUPCODE varchar(6) = '', 
@IBCALC bit = 0, 
@IBBCALC bit = 0, 
@INTERNALTAXDETAIL bit = 0, 
@IBBINTERNALTAX bit = 0, 
@INTERNALTAXCALC bit = 0, 
@IVADETAIL bit = 0, 
@IVACALC bit = 0, 
@IVAFREE bit = 0, 
@CITY varchar(20) = '', 
@IBNUMBER varchar(20) = '', 
@NAME varchar(60) = '', 
@SALESLISTCODE smallint = 0, 
@HOURS varchar(60) = '', 
@DISCOUNTPERCENT decimal = 0, 
@IVAEXCLUSIONPERCENT decimal = 0, 
@IVAFREEPERCENT decimal = 0, 
@LEGALNAME varchar(60) = '', 
@INTERNALTAXPLUS bit = 0, 
@IVAPLUS bit = 0, 
@PHONE varchar(30) = '', 
@FAX varchar(30) = '', 
@TIPO varchar(1) = '', 
@IDCODE smallint = 0, 
@ZONA_ENVIO varchar(2) = '', 
@FECHA_MODI datetime = '1800/01/01', 
@CURRENCYCODE BIT = 1, 
@SUCUR_ORI smallint = 0, 
@WEB varchar(60) = '', 
@COD_RUBRO varchar(4) = '', 
@NOTES varchar(max) = ''
)

AS

BEGIN

DECLARE @ID INT

	UPDATE DBO.GVA14
	SET
	CUIT  = @CUIT, 
	CUMPLEANIO  = CONVERT(DATETIME, @BIRTHDAY, 102), 
	CUPO_CREDI  = @CREDIT, 
	DIR_COM  = @ADRESS, 
	DOMICILIO  = @DELIVERYADRESS, 
	E_MAIL  = @MAIL, 
	EXPORTA  = @EXPORT, 
	GRUPO_EMPR  = @GROUPCODE, 
	IB_L  = @IBCALC, 
	IB_L3  = @IBBCALC, 
	II_D  = (CASE WHEN @INTERNALTAXDETAIL = 0 THEN 'N' ELSE 'S' END), 
	II_IB3  = @IBBINTERNALTAX, 
	II_L  = (CASE WHEN @INTERNALTAXCALC = 0 THEN 'N' ELSE 'S' END), 
	IVA_D  = (CASE WHEN @IVADETAIL = 0 THEN 'N' ELSE 'S' END), 
	IVA_L  = (CASE WHEN @IVACALC = 0 THEN 'N' ELSE 'S' END), 
	LIB  = (CASE WHEN @IVAFREE = 0 THEN 'N' ELSE 'S' END), 
	LOCALIDAD  = @CITY, 
	N_ING_BRUT  = @IBNUMBER, 
	NOM_COM  = @NAME, 
	NRO_LISTA  = @SALESLISTCODE, 
	OBSERVACIO  = @HOURS, 
	PORC_DESC  = @DISCOUNTPERCENT, 
	PORC_EXCL  = @IVAEXCLUSIONPERCENT, 
	PORC_L  = @IVAFREEPERCENT, 
	RAZON_SOCI  = @LEGALNAME, 
	SOBRE_II  = (CASE WHEN @INTERNALTAXPLUS = 0 THEN 'N' ELSE 'S' END), 
	SOBRE_IVA  = (CASE WHEN @IVAPLUS = 0 THEN 'N' ELSE 'S' END), 
	TELEFONO_1  = @PHONE, 
	TELEFONO_2  = @FAX, 
	MON_CTE  = @CURRENCYCODE, 
	FECHA_MODI = CONVERT(DATETIME, GETDATE(), 102)
	WHERE COD_CLIENT = @CODE

	SET @ID = @@ROWCOUNT

	IF @ID > 0
	BEGIN
		DELETE FROM GVA111 WHERE COD_CLIENT = @CODE
		INSERT INTO GVA111 (COD_CLIENT, NRO_RENGL, TEXTO)
					VALUES (@CODE, 1, @NOTES)		

		IF EXISTS (
		SELECT * FROM  <ownerdatabase>.dbo.REALCUSTOMERS
		WHERE ID_COMPANY = @COMPANY
		AND   COD_CLIENT = @CODE)

		UPDATE <ownerdatabase>.dbo.REALCUSTOMERS 
		SET WEB = @WEB
		WHERE ID_COMPANY = @COMPANY
		AND   COD_CLIENT = @CODE

		ELSE

		INSERT INTO <ownerdatabase>.dbo.REALCUSTOMERS (ID_COMPANY, COD_CLIENT, WEB)
					VALUES (@COMPANY, @CODE, @WEB)

	END

	RETURN @ID

RETURN 

END















CREATE PROCEDURE sp_InsertFile(
@NAME VARCHAR(100) = '',
@EXTENSION VARCHAR(10) = '',
@DATA VARBINARY(MAX)
)

AS 

BEGIN


INSERT INTO Attachments
           (ATTACHMENT_TITLE,ATTACHMENT_EXTENSION, ATTACHMENT_BODY)
     VALUES 
           (@NAME, @EXTENSION, @DATA)

RETURN @@IDENTITY

END


USE CRM
GO

DROP PROCEDURE sp_AsignFileToCustomer


CREATE PROCEDURE sp_AsignFileToCustomer(
@COMPANY VARCHAR(15) = '',
@CUSTOMER VARCHAR(6) = '',
@TASK VARCHAR(15) = '',
@ATTACHMENT VARCHAR(15) = ''
)

AS 

BEGIN

INSERT INTO ENTITIESATTACHMENTS
           (COMPANY_ID, CUSTOMERCODE, TASKCODE, ATTACHMENT_ID)
     VALUES
           (CAST(@COMPANY AS INT), @CUSTOMER, CAST(@TASK AS INT), CAST(@ATTACHMENT AS INT))

RETURN @@ROWCOUNT

END

USE CRM
GO

DROP PROCEDURE sp_InsertActionParameter


CREATE PROCEDURE sp_InsertActionParameter
(
@ID INT = 0,
@NAME VARCHAR(100) = '',
@TYPE INT = 0,
@VALUE VARCHAR(MAX) = ''
)

AS

BEGIN

	INSERT INTO ACTIONPARAMETERS
			   (ACTION_ID, PARAMETER_NAME, PARAMETER_TYPE, PARAMETER_VALUE)
		 VALUES
			   (@ID, @NAME, @TYPE, @VALUE)

	RETURN @@ROWCOUNT

END