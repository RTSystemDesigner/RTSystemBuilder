CREATE TABLE T_COMPONENT (
 id 			 	serial 	   		 NOT NULL,
 name 	 		 	character varying	 NOT NULL,
 component_name 	character varying	 NOT NULL,
 vendor	 		 	character varying	 NOT NULL,
 language 	 	 	smallint			 NOT NULL,
 repository 	 	character varying	 NOT NULL,
 comment 		 	character varying,
 PRIMARY KEY (id)
);

CREATE TABLE T_CATEGORY (
 id 			 serial 			 NOT NULL,
 component_id	 bigint				 NOT NULL,
 parent_id		 bigint,
 name 	 		 character varying	 NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY("component_id") REFERENCES T_COMPONENT("id")
);

CREATE TABLE T_DATA_PORT (
 id 		 serial 			 	NOT NULL,
 component_id	 bigint			 	NOT NULL,
 name		 	 character varying	 NOT NULL,
 type		 	 character varying	 NOT NULL,
 direction	 	 smallint			 NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY("component_id") REFERENCES T_COMPONENT("id")
);

CREATE TABLE T_SERVICE_PORT (
 id 		 	 serial 			 NOT NULL,
 component_id	 bigint			 	 NOT NULL,
 name		 	 character varying	 NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY("component_id") REFERENCES T_COMPONENT("id")
);

CREATE TABLE T_SERVICE_INTERFACE (
 id 		 		 serial 			 NOT NULL,
 service_port_id	 bigint		 		 NOT NULL,
 name		 	 	 character varying	 NOT NULL,
 direction	 	 	 smallint			 NOT NULL,
 interface_type	 	 character varying	 NOT NULL,
 PRIMARY KEY (id),
 FOREIGN KEY("service_port_id") REFERENCES T_SERVICE_PORT("id")
);

