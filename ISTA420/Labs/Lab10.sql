BEGIN TRAN;

  UPDATE Production.Products
    SET unitprice += 1.00
  WHERE productid = 3;
  SELECT orderid, productid, unitprice, qty, discount
  FROM Sales.OrderDetails
  WHERE orderid = 10249;

  -- 1-3
  -- Run the following code in Connection 3
  -- and identify the locks and process ids
  -- involved in the blocking chain:

  SELECT -- use * to explore
    request_session_id            AS sid,
    resource_type                 AS restype,
    resource_database_id          AS dbid,
    resource_description          AS res,
    resource_associated_entity_id AS resid,
    request_mode                  AS mode,
    request_status                AS status
  FROM sys.dm_tran_locks;

  -- 1-4
  -- In the following exercises replace the session ids 52, 53
  -- with the ones you found to be involved in the blocking chain
  -- in the previous exercise
  -- Run the following code to obtain connection/session/blocking
  -- information about the processes involved in the blocking chain

  -- Connection info
  SELECT -- use * to explore
    session_id AS sid,
    connect_time,
    last_read,
    last_write,
    most_recent_sql_handle
  FROM sys.dm_exec_connections
  WHERE session_id IN(52, 53);

  -- Session info
  SELECT -- use * to explore
    session_id AS sid,
    login_time,
    host_name,
    program_name,
    login_name,
    nt_user_name,
    last_request_start_time,
    last_request_end_time
  FROM sys.dm_exec_sessions
  WHERE session_id IN(52, 53);

  -- Blocking
  SELECT -- use * to explore
    session_id AS sid,
    blocking_session_id,
    command,
    sql_handle,
    database_id,
    wait_type,
    wait_time,
    wait_resource
  FROM sys.dm_exec_requests
  WHERE blocking_session_id > 0;

  -- 1-5
  -- Run the following code to obtain the SQL text of the connections
  -- involved in the blocking chain:

  -- SQL text
  SELECT session_id, text
  FROM sys.dm_exec_connections
    CROSS APPLY sys.dm_exec_sql_text(most_recent_sql_handle) AS ST
  WHERE session_id IN(52, 53);

  -- 1-6
  -- Run the following code in Connection 1 to rollback the transaction:
  ROLLBACK TRAN;
